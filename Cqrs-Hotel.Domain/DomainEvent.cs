using System;

namespace Cqrs.Hotel.Domain
{
    public class DomainEvent : IDomainEvent
    {
        public DateTime TimeStamp { get; private set; }

        public DomainEvent()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
