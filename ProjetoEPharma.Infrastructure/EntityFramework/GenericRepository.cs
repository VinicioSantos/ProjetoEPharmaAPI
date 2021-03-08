using Microsoft.EntityFrameworkCore;
using ProjetoEPharma.Infrastructure.EntityFramework.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoEPharma.Infrastructure.EntityFramework
{
    public abstract class GenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected readonly TContext _context;

        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(TContext context)
        {
            _dbSet = context.Set<TEntity>();
            _context = context;
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
        
        public virtual async Task<TEntity> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }
        
        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        
        public virtual void Add(List<TEntity> entity)
        {
            _dbSet.AddRange(entity);
        }
        
        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
        
        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }




    }
}
