using System;
using System.Collections.Generic;
using Cqrs.Hotel.Domain;

namespace Cqrs.Hotel.Infraestructure
{
    public class DomainEventRepository : IDomainEventRepository
    {
        private readonly List<Event> _events = new List<Event>();

        public void Add(DomainEvent @event)
        {
            var eventToAdd = new Event(Guid.NewGuid(), @event.GetType().Name, Newtonsoft.Json.JsonConvert.SerializeObject(@event));
            _events.Add(eventToAdd);
        } 
    }
}