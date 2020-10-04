using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OrionInnovation.Persistence;
using Microsoft.Extensions.Configuration;

namespace OrionInnovationApi.Extensions
{
    public static partial class SartupExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrionInnovationSqlDbContext>(opt =>
                    opt.UseMySql(configuration.GetConnectionString("OrionInnovationSqlConnection"),
                                  x => x.MigrationsAssembly("OrionInnovation.Persistence")));

            return services;
        }
    }
}