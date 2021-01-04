using EventSourcing.CQRS.Commands;

namespace EventSourcing.CQRS.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
