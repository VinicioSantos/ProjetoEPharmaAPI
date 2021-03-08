using ProjetoEPharma.Crosscutting.DTO;
using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Domain.Maps;
using ProjetoEPharma.Infrastructure.Repository.Interfaces;
using ProjetoEPharma.Infrastructure.UnitOfWork.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEPharma.Service.Modules
{
    public class ClienteApplicationService : BaseApplicationService<IClienteUnitOfWork>
    {
        private readonly ClienteMapper _mapper;

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
            var planos = _uow.PlanoRepository.ObterPlanosPorIds(dto.IdsPlanos);
            var entidade = _mapper.MapearEntidade(dto);

            if (planos.Any(x => x.FimVigencia < entidade.DataCadastro))
                throw new System.Exception("Alguma plano não Disponivel");

            using var transaction = await _uow.BeginTransaction();
            
            _uow.ClienteRepository.Add(entidade);
            await _uow.CommitAsync();
            
            _uow.PlanoClienteRepository.SalvarPlanosClientes(entidade.Id , dto.IdsPlanos);
            await _uow.CommitAsync();

            await transaction.CommitAsync();
            return entidade.Id;
        }
    }
}
