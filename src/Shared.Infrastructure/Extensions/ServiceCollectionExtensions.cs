using Microsoft.Extensions.DependencyInjection;
using Shared.Infrastructure.Controllers;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Bootstrapper")]

namespace Shared.Infrastructure.Extensions
{
    internal static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddControllers()
                .ConfigureApplicationPartManager(manager =>
                {
                    manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
                });

            return services;
        }
    }
}