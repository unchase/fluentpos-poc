using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Modules.Catalogs
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddCatalogsModule(this IServiceCollection services)
        {
            return services;
        }

        public static IApplicationBuilder UseCatalogsModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}