using Microsoft.Extensions.DependencyInjection;
using Pokedexx.Application.Application;
using Pokedexx.Domain.Application.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedexx.Application
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IGetPokemonByPokemonIdUseCase, GetPokemonByPokemonIdUseCase>();
            return services;
        }
    }
}
