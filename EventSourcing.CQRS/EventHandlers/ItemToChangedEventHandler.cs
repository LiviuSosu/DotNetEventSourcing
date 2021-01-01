using EventSourcing.CQRS.Events;
using EventSourcing.CQRS.Reporting;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.EventHandlers
{
    public class ItemToChangedEventHandler : IEventHandler<ItemToChangedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public ItemToChangedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(ItemToChangedEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            item.To = handle.To;
            item.Version = handle.Version;
        }
    }
}
