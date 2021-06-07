using Microsoft.AspNetCore.Builder;
using Shared.Infrastructure.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Bootstrapper")]
namespace Shared.Infrastructure.Extensions
{
    internal static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSharedInfrastructure(this IApplicationBuilder app)
        {

            app.UseRouting();
            app.UseMiddleware<GlobalExceptionHandler>();
            app.UseSwaggerDocumentation();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            return app;
        }
        private static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.DefaultModelsExpandDepth(-1);
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                options.RoutePrefix = "swagger";
                options.DisplayRequestDuration();
            });
            return app;
        }
    }
}
