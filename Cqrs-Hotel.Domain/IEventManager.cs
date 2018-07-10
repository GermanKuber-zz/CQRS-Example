using System;
using System.Collections.Generic;

namespace Cqrs.Hotel.Domain
{
    public interface IEventManager
    {
        IReadOnlyCollection<DomainEvent> UncommittedDomainEvents { get; }
        void RaiseEvents(Func<DomainEvent, bool> raiseEvent);
    }
}