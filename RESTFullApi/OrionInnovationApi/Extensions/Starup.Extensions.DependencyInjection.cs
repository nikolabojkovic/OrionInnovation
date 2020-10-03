using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OrionInnovation.Domain;
using OrionInnovation.Persistence;

namespace OrionInnovationApi.Extensions
{
    public static partial class SartupExtensions
    {
        public static IServiceCollection AddDepenedencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITextRepository, TextRepository>();

            return services;
        }
    }
}