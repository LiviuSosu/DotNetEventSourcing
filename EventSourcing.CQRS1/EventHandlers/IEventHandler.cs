using EventSourcing.CQRS.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.EventHandlers
{
    public interface IEventHandler<TEvent> where TEvent : Event
    {
        void Handle(TEvent handle);
    }
}
