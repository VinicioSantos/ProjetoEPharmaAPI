using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoEPharma.Service.DependencyInjection.ApplicationServiceInjection;
using ProjetoEPharma.Service.DependencyInjection.MapperInjection;
using ProjetoEPharma.Service.DependencyInjection.RepositoryInjection;
using ProjetoEPharma.Service.DependencyInjection.UnitOfWorkInjection;
using ProjetoEPharma.Service.DependencyInjection.ValidationInjection;

namespace ProjetoEPharma.Service.DependencyInjection
{
    public static class ConfigureBindingsDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureBindingsDatabaseContext.RegisterBindings(services, configuration);

            ConfigureBindingsCommonApplicationService.RegisterBindings(services);

            ConfigureBindingsCommonMapperService.RegisterBindings(services);

            ConfigureBindingsCommonRepositoryService.RegisterBindings(services);

            ConfigureBindingsCommonUnitOfWorkService.RegisterBindings(services);

            ConfigureBindingsCommonValidationService.RegisterBindings(services);
        }
    }
}
