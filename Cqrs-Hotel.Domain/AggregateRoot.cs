using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cqrs.Hotel.Domain
{
    public abstract class AggregateRoot : IAggregateRoot, IEventManager
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();

        private readonly List<DomainEvent> _uncommittedDomainEvents = new List<DomainEvent>();
        public IReadOnlyCollection<DomainEvent> UncommittedDomainEvents =>
            new ReadOnlyCollection<DomainEvent>(_uncommittedDomainEvents);

        public void RaiseEvents(Func<DomainEvent, bool> raiseEvent)
        {
            _uncommittedDomainEvents.ForEach(x => raiseEvent(x));
            _uncommittedDomainEvents.Clear();
        }

        protected void RaiseEvent(DomainEvent @event)
        {
            _uncommittedDomainEvents.Add(@event);
        }
    }
}