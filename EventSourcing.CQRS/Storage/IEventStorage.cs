using EventSourcing.CQRS.Domain;
using EventSourcing.CQRS.Events;
using EventSourcing.CQRS.Mementos;
using System;
using System.Collections.Generic;
using System.Text;

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
