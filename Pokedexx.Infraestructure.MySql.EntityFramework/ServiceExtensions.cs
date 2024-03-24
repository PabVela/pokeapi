using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pokedexx.Infraestructure.MySql.EntityFramework.Context;

namespace Pokedexx.Infraestructure.MySql.EntityFramework
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDatabaseMySql(this IServiceCollection services,IConfiguration cfg)
        {
            var connectionstring = cfg.GetConnectionString("DefaultConnection");
           
            services.AddDbContext<PokeapiContext>(optionsBuilder =>
                optionsBuilder.UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring), options =>
                {
                    options.EnableRetryOnFailure();
                    optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                }));

            return services;
        }
    }
}
