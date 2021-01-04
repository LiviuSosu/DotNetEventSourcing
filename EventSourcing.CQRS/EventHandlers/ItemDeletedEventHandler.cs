using EventSourcing.CQRS.Events;
using EventSourcing.CQRS.Reporting;

namespace EventSourcing.CQRS.EventHandlers
{
    public class ItemDeletedEventHandler : IEventHandler<ItemDeletedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public ItemDeletedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(ItemDeletedEvent handle)
        {
            _reportDatabase.Delete(handle.AggregateId);
        }
    }
}
