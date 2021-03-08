using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Infrastructure.EntityFramework.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoEPharma.Infrastructure.Repository.Interfaces
{
    public interface IPlanoRepository : IRepository<PlanoEntity>
    {
        List<PlanoEntity> ObterPlanosPorIds(List<int> ids);
    }
}
