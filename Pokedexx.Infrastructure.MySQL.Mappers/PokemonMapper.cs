using Pokedexx.Application.DTOs;
using Pokedexx.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedexx.Domain.Builders;

namespace Pokedexx.Application.Mappers
{
    public static class PokemonMapper
    {
        //PokemonDto
        public static PokemonDto ToDto(this Domain.Models.PokemonEntity pokemon)
        {
            return new PokemonDto()
            {
                Id = pokemon.Id.Value,
                Name = pokemon.Name.Value,
                Base_experience = pokemon.Base_experience.Value,
                Height = pokemon.Height.Value,
                Weight = pokemon.Weight.Value,
                Is_default = pokemon.Is_default.Value,
                Order = pokemon.Order.Value,
                Location_area_encounters = pokemon.Location_area_encounters?.Value
            };
        }

        public static IEnumerable<PokemonDto> ToDto(this IEnumerable<PokemonEntity> pokemon)
        {
            return pokemon.Select( x => x.ToDto()).ToList(); 
        } 

        //Pokemon
        public static PokemonEntity ToDomain(this PokemonDto pokemonDto)
        {
            return new PokemonBuilder()
                .WithId(pokemonDto.Id)
                .WithName(pokemonDto.Name)
                .WithBase_experience(pokemonDto.Base_experience)
                .WithHeight(pokemonDto.Height)
                .WithWeight(pokemonDto.Weight)
                .WithIs_default(pokemonDto.Is_default)
                .WithOrder(pokemonDto.Order)
                .WithLocation_area_encounters(string.IsNullOrEmpty(pokemonDto.Location_area_encounters) ? "" : pokemonDto.Location_area_encounters)
                .Build();
        }

        public static List<PokemonEntity> ToDomain(this List<PokemonDto> pokemons)
        {
            return pokemons.Select(x => x.ToDomain()).ToList();

        }
    }
}
