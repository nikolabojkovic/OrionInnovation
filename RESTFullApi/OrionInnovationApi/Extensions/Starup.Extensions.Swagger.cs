using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace OrionInnovationApi.Extensions
{
    public static partial class SartupExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => 
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Orion Innovation API",
                Description = "Orion Innovation API by Nikola Bojkovic",
                Contact = new OpenApiContact
                {
                    Name = "Nikola Bojkovic",
                    Email = string.Empty
                }
            }));

            return services;
        }

         public static IApplicationBuilder UseCustomSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Orion Innovation API V1");
                c.RoutePrefix = string.Empty;
            });
            
            return app;
        }
    }
}