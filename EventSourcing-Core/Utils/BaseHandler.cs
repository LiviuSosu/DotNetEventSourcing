using EventSourcing_Core.Messaging;
using MediatR;

namespace EventSourcing_Core.Utils
{
    public abstract class BaseHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        //TODO: remove if unnecessary
        private readonly ICommandBus _commandBus;
        public BaseHandler(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public abstract Task<TResponse> Handle(TRequest message, CancellationToken cancellationToken);
    }
}
