using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Commands
{
    public class DeleteItemCommand : Command
    {
        public DeleteItemCommand(Guid id, int version) : base(id, version)
        {
        }
    }
}
