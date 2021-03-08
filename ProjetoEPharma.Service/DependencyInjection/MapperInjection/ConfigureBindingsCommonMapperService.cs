using Microsoft.Extensions.DependencyInjection;
using ProjetoEPharma.Domain.Maps;

namespace ProjetoEPharma.Service.DependencyInjection.MapperInjection
{
    public class ConfigureBindingsCommonMapperService
    {
        public static void RegisterBindings(IServiceCollection service)
        {
            //DI da camada de Mapper
            service.AddScoped<ClienteMapper>();
            service.AddScoped<PlanoMapper>();
        }
    }
}
