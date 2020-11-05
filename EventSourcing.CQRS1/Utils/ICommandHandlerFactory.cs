using EventSourcing.CQRS.CommandHandlers;
using EventSourcing.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
