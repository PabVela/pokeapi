using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Pokedexx.Domain.ValueObjects;
using Pokedexx.Domain.Models;
using Pokedexx.Domain.Exceptions;
using System.Xml.Linq;

namespace Pokedexx.Domain.Builders
{
    public class PokemonBuilder
    {
        private readonly PokemonEntity _pokemon;

        public PokemonBuilder()
        { 
            _pokemon = new PokemonEntity();
        }

        public PokemonEntity Build()
        {
            if ( _pokemon.Id == null ) { throw new BusinessException("El id del pokemon no puede ser nulo"); }
            if ( _pokemon.Name == null ) { throw new BusinessException("El nombre del pokemon no puede ser nulo"); }
            if (_pokemon.Base_experience == null) { throw new BusinessException("La experiencia base del pokemon no puede ser nulo"); }
            if (_pokemon.Height == null) { throw new BusinessException("La altura del pokemon no puede ser nulo"); }
            if (_pokemon.Weight == null) { throw new BusinessException("El peso del pokemon no puede ser nulo"); }
            if (_pokemon.Is_default == null) { throw new BusinessException("El is_default del pokemon no puede ser nulo"); }
            if (_pokemon.Order == null) { throw new BusinessException("El order del pokemon no puede ser nulo"); }
        
            return _pokemon;
        }

        //Name
        public PokemonBuilder WithId(Id id)
        {
            _pokemon.Id = id;
            return this;
        }
        public PokemonBuilder WithId(int id)
        {
            return WithId(new Id(id));
        }

        //Name
        public PokemonBuilder WithName(StringWithValue name)
        {
            _pokemon.Name = name;
            return this;
        }
        public PokemonBuilder WithName(string name)
        {
            return WithName(new StringWithValue(name));
        }

        //Base_experience
        public PokemonBuilder WithBase_experience(NotNegativeIntValue exp)
        {
            _pokemon.Base_experience = exp;
            return this;
        }
        public PokemonBuilder WithBase_experience(int exp)
        {
            return WithBase_experience(new NotNegativeIntValue(exp));
        }

        //Height
        public PokemonBuilder WithHeight(NotNegativeIntValue height)
        {
            _pokemon.Height = height;
            return this;
        }
        public PokemonBuilder WithHeight(int height)
        {
            return WithHeight(new NotNegativeIntValue(height));
        }

        //Weight
        public PokemonBuilder WithWeight(NotNegativeIntValue weight)
        {
            _pokemon.Height = weight;
            return this;
        }
        public PokemonBuilder WithWeight(int weight)
        {
            return WithWeight(new NotNegativeIntValue(weight));
        }

        //Is_default
        public PokemonBuilder WithIs_default(NotNegativeIntValue is_default)
        {
            _pokemon.Is_default = is_default;
            return this;
        }
        public PokemonBuilder WithIs_default(int is_default)
        {
            return WithIs_default(new NotNegativeIntValue(is_default));
        }

        //Order
        public PokemonBuilder WithOrder(NotNegativeIntValue order)
        {
            _pokemon.Order = order;
            return this;
        }
        public PokemonBuilder WithOrder(int order)
        {
            return WithOrder(new NotNegativeIntValue(order));
        }

        //Location_area_encounters
        public PokemonBuilder WithLocation_area_encounters(StringWithValue location_area_encounters)
        {
            _pokemon.Location_area_encounters = location_area_encounters;
            return this;
        }
        public PokemonBuilder WithLocation_area_encounters(string location_area_encounters)
        {
            return WithLocation_area_encounters(new StringWithValue(location_area_encounters));
        }

    }
}
