using EventSourcing_Core.CommandHandlers;
using EventSourcing_Core.Commands;

namespace EventSourcing_Core.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
