using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEPharma.Infrastructure.EntityFramework.Interface
{
    public interface IRepository<TEntity>
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetByIdAsync(long id);
        void Add(TEntity entity);
        void Add(List<TEntity> entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
