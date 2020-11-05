using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Exceptions
{
    public class ConcurrencyException : Exception
    {
        public ConcurrencyException(string message) : base(message) { }
    }
}
