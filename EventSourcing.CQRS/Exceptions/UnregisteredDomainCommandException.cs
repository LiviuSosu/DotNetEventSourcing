using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Exceptions
{
    public  class UnregisteredDomainCommandException : Exception
    {
        public UnregisteredDomainCommandException(string message) : base(message) { }
    }
}
