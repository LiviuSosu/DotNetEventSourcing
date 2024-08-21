using EventSourcing_Core.Commands;

namespace EventSourcing_Core.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
