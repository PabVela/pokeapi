namespace Pokedexx.Domain.Exceptions
{
    public class HandledException : Exception
    {
        bool hideStackTrace = false;

        public HandledException() : base()
        {
        }

        public HandledException(string message) : base(message)
        {
        }

        public HandledException(Exception ex) : base(ex.InnerException != null ? $"{ex.Message}. {ex.InnerException.Message}" : ex.Message)
        {
        }

        public void HideStackTrace()
        {
            hideStackTrace = true;
        }

        public override string StackTrace
        {
            get
            {
                if (!hideStackTrace)
                {
                    return base.StackTrace;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

