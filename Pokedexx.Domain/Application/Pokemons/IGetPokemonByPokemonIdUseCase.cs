using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedexx.Domain.ValueObjects;
using Pokedexx.Domain.Models;

namespace Pokedexx.Domain.Application.Pokemons
{
    public interface IGetPokemonByPokemonIdUseCase
    {
        Task<PokemonEntity> ExecuteAsync(Id pokeId);
    }
}
