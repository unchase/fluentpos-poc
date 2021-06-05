using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shared.Infrastructure.Extensions;
using System;

namespace Shared.Infrastructure.Persistence.MySQL
{
    public static class Extensions
    {
        internal static IServiceCollection AddMySQL(this IServiceCollection services)
        {
            var options = services.GetOptions<MySQLOptions>("mysql");
            services.AddSingleton(options);

            return services;
        }
        public static IServiceCollection AddMySql<T>(this IServiceCollection services) where T : DbContext
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));
            var options = services.GetOptions<MySQLOptions>("mysql");
            services.AddDbContext<T>(m => m.UseMySql(options.ConnectionString, serverVersion,e=>e.MigrationsAssembly(typeof(T).Assembly.FullName)));
            using var scope = services.BuildServiceProvider().CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<T>();
            dbContext.Database.Migrate();
            return services;
        }
    }
}
