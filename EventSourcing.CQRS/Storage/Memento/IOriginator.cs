using EventSourcing.CQRS.Domain.Mementos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Storage.Memento
{
    public interface IOriginator
    {
        BaseMemento GetMemento();
        void SetMemento(BaseMemento memento);
    }
}
