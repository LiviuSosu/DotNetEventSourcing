using System;

namespace EventSourcing.CQRS.Events
{
    public class ItemDeletedEvent : Event
    {
        public ItemDeletedEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
