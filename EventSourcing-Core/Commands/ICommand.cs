
namespace EventSourcing_Core.Commands
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}
