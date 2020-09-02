using System;

namespace EventSourcing.CQRS.Commands
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}
