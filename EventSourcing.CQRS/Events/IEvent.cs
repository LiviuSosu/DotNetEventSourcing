using System;

namespace EventSourcing.CQRS.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}
