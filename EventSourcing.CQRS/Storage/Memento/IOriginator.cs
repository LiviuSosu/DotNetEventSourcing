using EventSourcing.CQRS.Domain.Mementos;

namespace EventSourcing.CQRS.Storage.Memento
{
    public interface IOriginator
    {
        BaseMemento GetMemento();
        void SetMemento(BaseMemento memento);
    }
}
