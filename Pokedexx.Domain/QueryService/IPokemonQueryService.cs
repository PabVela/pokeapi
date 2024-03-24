using Pokedexx.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedexx.Domain.ValueObjects;

namespace Pokedexx.Domain.QueryService
{
    public interface IPokemonQueryService
    {
        public Task<PokemonEntity?> GetPokemonByIdAsync(Id id);
    }
}
