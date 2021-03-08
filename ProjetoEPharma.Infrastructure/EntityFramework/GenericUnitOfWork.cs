using Microsoft.EntityFrameworkCore;
using ProjetoEPharma.Infrastructure.EntityFramework.Interface;
using ProjetoEPharma.Infrastructure.Model;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace ProjetoEPharma.Infrastructure.EntityFramework
{
    public abstract class GenericUnitOfWork : IUnitOfWork
    {
        protected CommonModel Context { get; set; }
        protected readonly IServiceProvider _serviceProvider;

        public GenericUnitOfWork(CommonModel context, IServiceProvider serviceProvider)
        {
            Context = context;
            _serviceProvider = serviceProvider;
        }

        public async virtual Task CommitAsync()
        {
            try
            {
                await Context.SaveChangesAsync();
            }catch(DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message);
            }
        }

        public async Task<IDbContextTransaction> BeginTransaction() => await Context.Database.BeginTransactionAsync();

    }
}
