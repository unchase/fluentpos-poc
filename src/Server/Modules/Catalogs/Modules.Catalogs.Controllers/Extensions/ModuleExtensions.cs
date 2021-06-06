using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Modules.Catalogs.Infrastructure.Extensions;

namespace Modules.Catalogs
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddCatalogsModule(this IServiceCollection services)
        {
            services.AddCatalogsInfrastructure();
            return services;
        }

        public static IApplicationBuilder UseCatalogsModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}