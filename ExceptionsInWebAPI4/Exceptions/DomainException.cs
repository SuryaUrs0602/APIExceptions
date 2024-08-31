namespace ExceptionsInWebAPI4.Exceptions
{
    public abstract class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {

        }
    }

    public class DomainNotFoundException : DomainException
    {
        public DomainNotFoundException(string message) : base (message) 
        {
            
        }
    }

    public class DomainInternalServerError : DomainException
    {
        public DomainInternalServerError(string message) : base(message)
        {
            
        }
    }
}
