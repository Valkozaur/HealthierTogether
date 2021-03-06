namespace HealthierTogether.Server.Infrastructure.Extensions
{
    using HealthierTogether.Server.Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationBuilderExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();

            var dbContext = services.ServiceProvider.GetService<HealthierTogetherDbContext>();

            dbContext.Database.Migrate();
        }

        public static IApplicationBuilder ApplyEnvironmentSettings(this IApplicationBuilder app)
            => app
                .UseDeveloperExceptionPage()
                .UseMigrationsEndPoint();
    }
}
