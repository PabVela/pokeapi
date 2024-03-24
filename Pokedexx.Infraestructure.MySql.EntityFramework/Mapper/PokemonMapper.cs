using Pokedexx.Domain.Builders;
using Pokedexx.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedexx.Infraestructure.MySql.EntityFramework.Mapper
{
    public static class PokemonMapper
    {
        public static PokemonEntity ToDomain(this EntityFramework.Entities.Pokemon pokemon)
        {
            return new PokemonBuilder()
                .WithId(pokemon.Id)
                .WithName(pokemon.Name)
                .WithWeight(pokemon.Weight)
                .Build();
        } 
    }
}
