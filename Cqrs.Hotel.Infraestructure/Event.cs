using System;

namespace Cqrs.Hotel.Infraestructure
{
    public class Event
    {
        public Guid Id { get; }
        public DateTime Date { get; } = DateTime.Now;
        public string Name { get; }
        public string EventBody { get; }

        public Event(Guid id, string name, string eventBody)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            EventBody = eventBody ?? throw new ArgumentNullException(nameof(eventBody));
        }
    }
}