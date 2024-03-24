using Pokedexx.Domain.Exceptions;
namespace Pokedexx.Domain.ValueObjects
{
    public class PokemonName : StringWithValue
    {
        public PokemonName(string value) : base(value)
        {
            ValidatePokemonName(value);
        }

        private static void ValidatePokemonName(string name)
        {
            bool valid = true;

            if (name.Length > 255)
            {
                valid = false;
            }

            if (!valid)
            {
                throw new BusinessException($"Invalid Name value: {name}");
            }
        }
    }
}

