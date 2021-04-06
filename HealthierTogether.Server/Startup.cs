namespace HealthierTogether.Server
{
    using HealthierTogether.Server.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        =>  services
                .AddDatabase(this.Configuration)
                .AddDatabaseDeveloperPageExceptionFilter()
                .AddIdentity()
                .AddJwtAuthentication(this.Configuration)
                .AddControllers(); 

        public void Configure(IApplicationBuilder app)
            => app
                .ApplyEnvironmentSettings()
                .UseRouting()
                .UseAuthentication()
                .UseAuthorization()
                .UseCors(x => x
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    )
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                })
                .ApplyMigrations();
    }
}
