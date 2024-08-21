using EventSourcing_Core.Commands;

namespace EventSourcing_Core.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }
}
