using EventSourcing.CQRS.EventHandlers;
using EventSourcing.CQRS.Events;
using System.Collections.Generic;

namespace EventSourcing.CQRS.Utils
{
    public interface IEventHandlerFactory
    {
        IEnumerable<IEventHandler<T>> GetHandlers<T>() where T : Event;
    }
}
