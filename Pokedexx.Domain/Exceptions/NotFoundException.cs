using System;
namespace Pokedexx.Domain.Exceptions
{
    public class NotFoundException : HandledException
    {
        public NotFoundException() : base()
        {
        }

        public NotFoundException(string message) : base(message)
        {
        }
    }
}

