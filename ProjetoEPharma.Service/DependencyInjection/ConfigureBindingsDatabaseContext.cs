using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoEPharma.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ProjetoEPharma.Service.DependencyInjection
{
    public class ConfigureBindingsDatabaseContext
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<CommonModel>(
                    options => options.UseSqlServer(configuration.GetConnectionString("epharma")
                ));
        }
    }
}
