﻿using EventSourcing.CQRS.Events;

namespace EventSourcing.CQRS.EventHandlers
{
    public interface IEventHandler<TEvent> where TEvent : Event
    {
        void Handle(TEvent handle);
    }
}
