using Microsoft.Extensions.DependencyInjection;
using ProjetoEPharma.Service.Modules;

namespace ProjetoEPharma.Service.DependencyInjection.ApplicationServiceInjection
{
    public class ConfigureBindingsCommonApplicationService
    {
        public static void RegisterBindings(IServiceCollection service)
        {
            //DI da camada de Aplicação
            service.AddScoped<ClienteApplicationService>();
            service.AddScoped<PlanoApplicationService>();
        }
    }
}
