using EventSourcing_Core.Commands;

namespace EventSourcing_Core.CommandHandlers
{
    public class CreateItemCommandHandler : ICommandHandler<CreateItemCommand>
    {
       // private IRepository<DiaryItem> _repository;

        public void Execute(CreateItemCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
