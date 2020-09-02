using EventSourcing.CQRS.Messaging;
using System;

namespace NetEventSourcing.Configuration
{
    public sealed class ServiceLocator
    {
        private static ICommandBus _commandBus;

        static ServiceLocator()
        {

        }

        public static ICommandBus CommandBus
        {
            get { return _commandBus; }
        }
    }
}
