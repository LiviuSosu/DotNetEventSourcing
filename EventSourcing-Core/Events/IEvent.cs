
namespace EventSourcing_Core.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}
