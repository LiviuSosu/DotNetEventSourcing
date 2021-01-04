using EventSourcing.CQRS.Domain;
using EventSourcing.CQRS.Domain.Mementos;
using EventSourcing.CQRS.Events;
using System;
using System.Collections.Generic;

namespace EventSourcing.CQRS.Storage
{
    public interface IEventStorage
    {
        IEnumerable<Event> GetEvents(Guid aggregateId);
        void Save(AggregateRoot aggregate);
        T GetMemento<T>(Guid aggregateId) where T : BaseMemento;
        void SaveMemento(BaseMemento memento);
    }
}
