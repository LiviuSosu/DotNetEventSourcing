using EventSourcing.CQRS.Domain.Mementos;
using EventSourcing.CQRS.Events;
using EventSourcing.CQRS.Storage.Memento;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.CQRS.Domain
{
    public class DiaryItem : AggregateRoot,
        IHandle<ItemCreatedEvent>,
        IOriginator
    {
        public string Title { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Description { get; set; }

        public DiaryItem()
        {

        }

        public void Handle(ItemCreatedEvent e)
        {
            Title = e.Title;
            From = e.From;
            To = e.To;
            Id = e.AggregateId;
            Description = e.Description;
            Version = e.Version;
        }

        public DiaryItem(Guid id, string title, string description, DateTime from, DateTime to)
        {
            ApplyChange(new ItemCreatedEvent(id, title, description, from, to));
        }

        public BaseMemento GetMemento()
        {
            return new DiaryItemMemento(Id, Title, Description, From, To, Version);
        }

        public void ChangeTitle(string title)
        {
            ApplyChange(new ItemRenamedEvent(Id, title));
        }

        public void ChangeDescription(string description)
        {
            ApplyChange(new ItemDescriptionChangedEvent(Id, description));
        }

        public void ChangeFrom(DateTime from)
        {
            ApplyChange(new ItemFromChangedEvent(Id, from));
        }

        public void ChangeTo(DateTime to)
        {
            ApplyChange(new ItemToChangedEvent(Id, to));
        }

        public void SetMemento(BaseMemento memento)
        {
            Title = ((DiaryItemMemento)memento).Title;
            To = ((DiaryItemMemento)memento).To;
            Version = memento.Version;
            From = ((DiaryItemMemento)memento).From;
            Description = ((DiaryItemMemento)memento).Description;
            Id = memento.Id;
        }
    }
}
