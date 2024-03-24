using Pokedexx.Domain.Exceptions;

namespace Pokedexx.Domain.ValueObjects
{
    public class StringWithValue : NullableStringValue
    {
        public StringWithValue(string? value) : base(value)
        {
            ValidateStringHasValue(value);
        }

        public new string Value
        {
            get { return ValidateAndGetValue(); }
        }

        public new string ToString()
        {
            return Value;
        }

        private void ValidateStringHasValue(string? value)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                valid = false;
            }

            if (!valid)
            {
                throw new BusinessException($"Invalid string value. Value cannot be null or empty", value);
            }
        }

        private string ValidateAndGetValue()
        {
            if (string.IsNullOrEmpty(base.Value) || string.IsNullOrWhiteSpace(base.Value))
            {
                throw new BusinessException($"Invalid string value. Value cannot be null or empty", base.Value);
            }

            return base.Value;
        }
    }
}

