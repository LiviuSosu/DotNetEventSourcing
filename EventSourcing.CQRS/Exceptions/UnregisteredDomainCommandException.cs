using System;

namespace EventSourcing.CQRS.Exceptions
{
    public  class UnregisteredDomainCommandException : Exception
    {
        public UnregisteredDomainCommandException(string message) : base(message) { }
    }
}
