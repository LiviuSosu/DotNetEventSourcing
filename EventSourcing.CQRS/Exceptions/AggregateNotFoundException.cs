using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Exceptions
{
    public class AggregateNotFoundException : Exception
    {
        public AggregateNotFoundException(string message) : base(message) { }
    }
}
