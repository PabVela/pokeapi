using Pokedexx.Domain.ValueObjects;

namespace Pokedexx.Domain.Models
{
    public class PokemonEntity
    {
        public Id Id { get; set; }
        public StringWithValue Name { get; set; }
        public NotNegativeIntValue Base_experience { get; set; }
        public NotNegativeIntValue Height { get; set; }
        public NotNegativeIntValue Weight { get; set; }
        public NotNegativeIntValue Is_default { get; set; }
        public NotNegativeIntValue Order { get; set; }
        public NullableStringValue? Location_area_encounters { get; set; }

        internal PokemonEntity()
        {
        }
    }
}

