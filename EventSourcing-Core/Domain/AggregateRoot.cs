using EventSourcing_Core.Events;
using Microsoft.Extensions.Logging;

namespace EventSourcing_Core.Domain
{
    public class AggregateRoot : IEventProvider
    {
        private readonly List<Event> _changes;
    }
}
