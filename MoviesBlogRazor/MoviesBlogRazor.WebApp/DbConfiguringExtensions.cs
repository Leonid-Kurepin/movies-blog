using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesBlogRazor.WebApp.Models;

namespace MoviesBlogRazor.WebApp
{
    public static class DbConfiguringExtensions
    {
        public static void UpdateDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<MoviesBlogRazorContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
