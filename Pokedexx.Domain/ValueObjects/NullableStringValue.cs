namespace Pokedexx.Domain.ValueObjects
{
    public class NullableStringValue
    {
        public string? Value { get; }

        public NullableStringValue(string? value)
        {
            Value = value;
        }
    }
}

