using Microsoft.Extensions.DependencyInjection;
using Modules.Catalogs.Infrastructure.Persistence;
using Shared.Infrastructure.Persistence.MSSQL;
using Shared.Infrastructure.Persistence.MySQL;

namespace Modules.Catalogs.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCatalogsInfrastructure(this IServiceCollection services)
        {
            services.AddMSSQL<CatalogsDbContext>();
            return services;
        }
    }
}
