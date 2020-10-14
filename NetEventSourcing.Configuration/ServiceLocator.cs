using EventSourcing.CQRS.Messaging;
using EventSourcing.CQRS.Reporting;
using EventSourcing.CQRS.Storage;
using EventSourcing.CQRS.Utils;
using StructureMap;

namespace NetEventSourcing.Configuration
{
    public sealed class ServiceLocator
    {
        private static ICommandBus _commandBus;
        private static bool _isInitialized;
        private static readonly object _lockThis = new object();
        private static IReportDatabase _reportDatabase;

        static ServiceLocator()
        {
            if (!_isInitialized)
            {
                lock (_lockThis)
                {
                    ContainerBootstrapper.BootstrapStructureMap();
                    _commandBus = ObjectFactory.GetInstance<ICommandBus>();
                    _reportDatabase = ObjectFactory.GetInstance<IReportDatabase>();
                    _isInitialized = true;
                }
            }
        }

        public static ICommandBus CommandBus
        {
            get { return _commandBus; }
        }
    }

    static class ContainerBootstrapper
    {
        public static void BootstrapStructureMap()
        {

            ObjectFactory.Initialize(x =>
            {
                x.For(typeof(IRepository<>)).Singleton().Use(typeof(Repository<>));
                x.For<IEventStorage>().Singleton().Use<InMemoryEventStorage>();
                x.For<IEventBus>().Use<EventBus>();
                x.For<ICommandHandlerFactory>().Use<StructureMapCommandHandlerFactory>();
                x.For<IEventHandlerFactory>().Use<StructureMapEventHandlerFactory>();
                x.For<ICommandBus>().Use<CommandBus>();
                x.For<IEventBus>().Use<EventBus>();
                x.For<IReportDatabase>().Use<ReportDatabase>();
            });
        }
    }
}
