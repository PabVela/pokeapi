using System.Text.RegularExpressions;
using Pokedexx.Domain.Exceptions;

namespace Pokedexx.Domain.ValueObjects
{
    public class Id : NotNegativeIntValue
    {
        public Id(int value) : base(value)
        {

        }

    }
}

