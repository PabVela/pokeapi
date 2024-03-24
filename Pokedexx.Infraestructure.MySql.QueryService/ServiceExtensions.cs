using Microsoft.Extensions.DependencyInjection;
using Pokedexx.Domain.QueryService;
using Pokedexx.Infraestructure.MySql.QueryService.Pokemon;

namespace Pokedexx.Infraestructure.MySql.QueryService
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddQueryService(this IServiceCollection service)
        {
            service.AddScoped<IPokemonQueryService, PokemonQueryService>();
            return service;
        }
    }
}
