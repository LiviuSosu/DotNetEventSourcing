﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Events
{
    public class ItemRenamedEvent : Event
    {
        public string Title { get; internal set; }
        public ItemRenamedEvent(Guid aggregateId, string title)
        {
            AggregateId = aggregateId;
            Title = title;
        }
    }
}