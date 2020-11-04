using EventSourcing.CQRS.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Domain
{
    public interface IEventProvider
    {
        void LoadsFromHistory(IEnumerable<Event> history);
        IEnumerable<Event> GetUncommittedChanges();
    }
}
