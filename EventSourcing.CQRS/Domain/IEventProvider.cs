using EventSourcing.CQRS.Events;
using System.Collections.Generic;

namespace EventSourcing.CQRS.Domain
{
    public interface IEventProvider
    {
        void LoadsFromHistory(IEnumerable<Event> history);
        IEnumerable<Event> GetUncommittedChanges();
    }
}
