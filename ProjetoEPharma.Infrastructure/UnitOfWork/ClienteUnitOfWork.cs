using Microsoft.Extensions.DependencyInjection;
using ProjetoEPharma.Infrastructure.EntityFramework;
using ProjetoEPharma.Infrastructure.Model;
using ProjetoEPharma.Infrastructure.Repository.Interfaces;
using ProjetoEPharma.Infrastructure.UnitOfWork.Interfaces;
using System;

namespace ProjetoEPharma.Infrastructure.UnitOfWork
{
    public class ClienteUnitOfWork : GenericUnitOfWork, IClienteUnitOfWork
    {

        public IClienteRepository ClienteRepository => _serviceProvider.GetService<IClienteRepository>();

        public IPlanoClienteRepository PlanoClienteRepository => _serviceProvider.GetService<IPlanoClienteRepository>();

        public IPlanoRepository PlanoRepository => _serviceProvider.GetService<IPlanoRepository>();

        public ClienteUnitOfWork(CommonModel context, IServiceProvider serviceProvider) : base(context, serviceProvider)
        {
        }

    }
}
