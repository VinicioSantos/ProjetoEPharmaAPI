using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace ProjetoEPharma.Infrastructure.EntityFramework.Interface
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        Task<IDbContextTransaction> BeginTransaction();
    }
}
