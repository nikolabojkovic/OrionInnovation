using Microsoft.AspNetCore.Builder;
using OrionInnovationApi.Middlewares;

namespace OrionInnovationApi.Extensions
{
    public static partial class SartupExtensions
    {
         public static IApplicationBuilder AddMiddlewares(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();
            
            return app;
        }
    }
}