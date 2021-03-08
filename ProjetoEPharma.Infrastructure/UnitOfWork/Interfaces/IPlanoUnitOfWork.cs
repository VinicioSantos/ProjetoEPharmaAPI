using ProjetoEPharma.Infrastructure.EntityFramework.Interface;
using ProjetoEPharma.Infrastructure.Repository.Interfaces;

namespace ProjetoEPharma.Infrastructure.UnitOfWork.Interfaces
{
    public interface IPlanoUnitOfWork : IUnitOfWork
    {
        IPlanoRepository PlanoRepository { get; }
    }
}
