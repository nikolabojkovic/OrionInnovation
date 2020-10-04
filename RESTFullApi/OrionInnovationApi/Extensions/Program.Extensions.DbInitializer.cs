using Microsoft.Extensions.DependencyInjection;
using OrionInnovation.Persistence;
using Microsoft.AspNetCore.Hosting;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace OrionInnovationApi.Extensions
{
    public static partial class ProgramExtensions
    {
        public static IHost SeedDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<OrionInnovationSqlDbContext>();
                    DbInitializer.Initialize(context);
                    DbInitializer.SeedText(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            return host;
        }
    }
}