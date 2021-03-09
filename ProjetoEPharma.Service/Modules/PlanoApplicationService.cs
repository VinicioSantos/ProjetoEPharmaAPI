using ProjetoEPharma.Crosscutting.DTO;
using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Domain.Maps;
using ProjetoEPharma.Infrastructure.UnitOfWork.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoEPharma.Service.Modules
{
    public class PlanoApplicationService : BaseApplicationService<IPlanoUnitOfWork>
    {
        private readonly PlanoMapper _mapper;

        public PlanoApplicationService(IPlanoUnitOfWork uow, PlanoMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        public async Task<List<PlanoEntity>> ObterTodos()
        {
            return await _uow.PlanoRepository.GetAll();
        }

        public async Task<int> SalvaPlano(PlanoDto dto)
        {
            var entidade = _mapper.MapearEntidade(dto);
            _uow.PlanoRepository.Add(entidade);
            await _uow.CommitAsync();
            return entidade.Id;
        }
    }
}
