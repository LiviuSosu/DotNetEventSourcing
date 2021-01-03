using System;
using System.Collections.Generic;
using System.Text;

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
