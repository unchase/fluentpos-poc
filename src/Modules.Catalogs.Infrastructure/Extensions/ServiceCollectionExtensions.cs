using Microsoft.Extensions.DependencyInjection;
using Modules.Catalogs.Infrastructure.Persistence;
using Shared.Infrastructure.Persistence.MSSQL;
using Shared.Infrastructure.Persistence.MySQL;
using Shared.Infrastructure.Persistence.Postgres;

namespace Modules.Catalogs.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCatalogsInfrastructure(this IServiceCollection services)
        {
            services.AddPostgres<CatalogsDbContext>();
            return services;
        }
    }
}
