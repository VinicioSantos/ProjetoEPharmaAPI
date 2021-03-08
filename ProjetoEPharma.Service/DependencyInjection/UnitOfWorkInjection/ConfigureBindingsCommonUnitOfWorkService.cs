using Microsoft.Extensions.DependencyInjection;
using ProjetoEPharma.Infrastructure.UnitOfWork;
using ProjetoEPharma.Infrastructure.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEPharma.Service.DependencyInjection.UnitOfWorkInjection
{
    public class ConfigureBindingsCommonUnitOfWorkService
    {
        public static void RegisterBindings(IServiceCollection service)
        {
            //DI da camada de unidade de trabalho
            service.AddScoped<IClienteUnitOfWork, ClienteUnitOfWork>();
            service.AddScoped<IPlanoUnitOfWork, PlanoUnitOfWork>();
        }
    }
}
