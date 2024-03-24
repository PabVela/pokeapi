
using Dapper;
using Microsoft.EntityFrameworkCore;
using Pokedexx.Domain.Models;
using Pokedexx.Domain.QueryService;
using Pokedexx.Infraestructure.MySql.EntityFramework.Context;
using Pokedexx.Infraestructure.MySql.EntityFramework.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedexx.Domain.ValueObjects;

namespace Pokedexx.Infraestructure.MySql.QueryService.Pokemon
{
    public class PokemonQueryService:IPokemonQueryService
    {
        private readonly PokeapiContext _context;
        public PokemonQueryService(PokeapiContext context)
        {
            _context = context;
        }
        public async Task<PokemonEntity?> GetPokemonByIdAsync(Id id)
        {
            var sql = "SELECT id," +
                "name," +
                "base_experience as BaseExperience ," +
                "height,weight,is_default,order,location_area_encounters from pokemon where id=@id";
            var entity =await _context.Database.GetDbConnection().QueryFirstOrDefaultAsync<EntityFramework.Entities.Pokemon>(sql, new { id=id.Value });
            return entity?.ToDomain();



        }
    }
}