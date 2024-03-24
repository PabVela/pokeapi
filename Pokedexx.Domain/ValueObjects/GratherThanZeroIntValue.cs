using Pokedexx.Domain.Exceptions;

namespace Pokedexx.Domain.ValueObjects
{
    public class GratherThanZeroIntValue
    {
        public int Value { get; }

        public GratherThanZeroIntValue(int value)
        {
            ValidateGreatherThanZero(value);

            Value = value;
        }

        private static void ValidateGreatherThanZero(int value)
        {
            if (value <= 0)
            {
                throw new BusinessException($"Value must be greather than zero: {value}");
            }
        }
    }
}

