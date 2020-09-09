using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}
