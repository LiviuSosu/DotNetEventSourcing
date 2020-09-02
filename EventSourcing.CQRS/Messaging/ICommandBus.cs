using EventSourcing.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
