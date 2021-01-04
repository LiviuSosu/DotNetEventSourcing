using EventSourcing.CQRS.CommandHandlers;
using EventSourcing.CQRS.Commands;

namespace EventSourcing.CQRS.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
