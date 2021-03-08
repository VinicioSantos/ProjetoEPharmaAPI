using Microsoft.Extensions.DependencyInjection;
using ProjetoEPharma.Infrastructure.Repository;
using ProjetoEPharma.Infrastructure.Repository.Interfaces;

namespace ProjetoEPharma.Service.DependencyInjection.RepositoryInjection
{
    public class ConfigureBindingsCommonRepositoryService
    {

        public static void RegisterBindings(IServiceCollection service)
        {
            //DI da camada de Repositório
            service.AddScoped<IClienteRepository, ClienteRepository>();
            service.AddScoped<IPlanoRepository, PlanoRepository>();
            service.AddScoped<IPlanoClienteRepository, PlanoClienteRepository>();
        }
    }
}
