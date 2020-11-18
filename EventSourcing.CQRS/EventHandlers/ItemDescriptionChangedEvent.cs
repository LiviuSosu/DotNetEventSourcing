using EventSourcing.CQRS.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.EventHandlers
{
    public class ItemDescriptionChangedEvent : Event
    {
        public string Description { get; internal set; }
        public ItemDescriptionChangedEvent(Guid aggregateId, string description)
        {
            AggregateId = aggregateId;
            Description = description;
        }
    }
}
