using Pokedexx.Domain.Application.Pokemons;
using Pokedexx.Domain.Models;
using Pokedexx.Domain.QueryService;
using Pokedexx.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedexx.Application.Application
{
    public class GetPokemonByPokemonIdUseCase : IGetPokemonByPokemonIdUseCase
    {
        private readonly IPokemonQueryService _querySerivce;

        
        public GetPokemonByPokemonIdUseCase(IPokemonQueryService querySerivce)
        {
           _querySerivce = querySerivce;
        }
        public async Task<PokemonEntity> ExecuteAsync(Id? pokeId)
        {
            PokemonEntity entity = null!;
            var bdEntity = await _querySerivce.GetPokemonByIdAsync(pokeId!);
            if(bdEntity == null)
            {
                //pedimos poke api
                
            }
            return entity;
        }
    }
}
