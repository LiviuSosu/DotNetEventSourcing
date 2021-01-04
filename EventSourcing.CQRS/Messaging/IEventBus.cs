using EventSourcing.CQRS.Events;

namespace EventSourcing.CQRS.Messaging
{
    public interface IEventBus
    {
        void Publish<T>(T @event) where T : Event;
    }
}
