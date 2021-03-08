using Microsoft.Extensions.DependencyInjection;
using ProjetoEPharma.Infrastructure.EntityFramework;
using ProjetoEPharma.Infrastructure.Model;
using ProjetoEPharma.Infrastructure.Repository.Interfaces;
using ProjetoEPharma.Infrastructure.UnitOfWork.Interfaces;
using System;

namespace ProjetoEPharma.Infrastructure.UnitOfWork
{
    public class PlanoUnitOfWork : GenericUnitOfWork, IPlanoUnitOfWork
    {
        public IPlanoRepository PlanoRepository => _serviceProvider.GetService<IPlanoRepository>();
        
        public PlanoUnitOfWork(CommonModel context, IServiceProvider serviceProvider) : base(context, serviceProvider)
        {
        }

    }
}
