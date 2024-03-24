using Pokedexx.Domain.Exceptions;

namespace Pokedexx.Domain.ValueObjects
{
    public class NotNegativeIntValue
    {
        public int Value { get; }

        public NotNegativeIntValue(int value)
        {
            ValidateNotNegative(value);

            Value = value;
        }

        private static void ValidateNotNegative(int value)
        {
            if (value < 0)
            {
                throw new BusinessException($"Value cannot be negative: {value}");
            }
        }
    }
}

