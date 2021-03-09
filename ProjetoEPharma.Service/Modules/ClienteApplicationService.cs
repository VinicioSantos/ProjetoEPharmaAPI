using ProjetoEPharma.Crosscutting.DTO;
using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Domain.Maps;
using ProjetoEPharma.Infrastructure.UnitOfWork.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEPharma.Service.Modules
{
    public class ClienteApplicationService : BaseApplicationService<IClienteUnitOfWork>
    {
        private readonly ClienteMapper _mapper;
        private bool isPessoaFisica;

        public ClienteApplicationService( IClienteUnitOfWork uow, ClienteMapper mapper ) : base(uow)
        {
            _mapper = mapper;
        }

        public async Task<List<ClienteEntity>> ObterTodos()
        {
            var clientes = await _uow.ClienteRepository.ObterTodosCliente();
            return clientes;
        }

        public async Task<int> SalvaCliente(SalvaClienteDto dto)
        {
            var entidade = _mapper.MapearEntidade(dto);

            var isPessoaFisica = VerificaPessoaFisica(dto.CPF, dto.CNPJ);

            if (isPessoaFisica && (string.IsNullOrEmpty(dto.RG) || dto.DataNascimento == null))
                throw new System.Exception("Dados de Pessoa Fisica incompletos, forneça RG e Data de Nascimento");

            if (dto.IdsPlanos.Count > 0)
            {
                var planos = _uow.PlanoRepository.ObterPlanosPorIds(dto.IdsPlanos);
                ValidaPlano(planos, entidade);
            }
            using var transaction = await _uow.BeginTransaction();
            
            _uow.ClienteRepository.Add(entidade);
            await _uow.CommitAsync();

            if (dto.IdsPlanos.Count > 0)
            {
                _uow.PlanoClienteRepository.SalvarPlanosClientes(entidade.Id, dto.IdsPlanos);
                await _uow.CommitAsync();
            }

            await transaction.CommitAsync();
            return entidade.Id;
        }

        private bool VerificaPessoaFisica(string cpf, string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj) && string.IsNullOrEmpty(cpf) || !string.IsNullOrEmpty(cnpj) && !string.IsNullOrEmpty(cpf))
                throw new System.Exception("Impossível definir se Cliente é Pessoa Física ou Juridica");

            bool isPessoaFisica;
            if (string.IsNullOrEmpty(cnpj))
                return isPessoaFisica = true;
            else
                return isPessoaFisica = false;
        }

        private void ValidaPlano(List<PlanoEntity> planos, ClienteEntity entidade)
        {
            if (planos.Any(x => x.FimVigencia < entidade.DataCadastro))
                throw new System.Exception("Algum plano assosciado não Disponivel ao cliente");
            if (planos.Any(x => x.PermitePessoaJuridica == 'N' && !isPessoaFisica))
                throw new System.Exception("Plano não atende pessoas juridicas");
        }
    }
}
