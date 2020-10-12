using EventSourcing.CQRS.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Messaging
{
    public interface IEventBus
    {
        void Publish<T>(T @event) where T : Event;
    }
}
