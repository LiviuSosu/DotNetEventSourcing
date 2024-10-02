using EventSourcing_Core.Events;
using Microsoft.Extensions.Logging;

namespace EventSourcing_Core.Domain
{
    public interface IEventProvider
    {
        void LoadsFromHistory(IEnumerable<Event> history);
        IEnumerable<Event> GetUncommittedChanges();
    }
}
