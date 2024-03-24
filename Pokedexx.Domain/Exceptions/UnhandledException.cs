namespace Pokedexx.Domain.Exceptions
{
    public class UnhandledException : HandledException
    {
        public UnhandledException(Exception ex) : base(ex)
        {
        }
    }
}

