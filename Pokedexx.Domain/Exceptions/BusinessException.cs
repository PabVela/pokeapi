namespace Pokedexx.Domain.Exceptions
{
    public class BusinessException : HandledException
    {
        public BusinessException() : base()
        {
        }

        public BusinessException(string message) : base(message)
        {
        }

        public BusinessException(string message, string? value) : base(message)
        {

            if (!string.IsNullOrEmpty(value))
            {
                base.Data.Add("Value", value);
            }
        }
    }
}

