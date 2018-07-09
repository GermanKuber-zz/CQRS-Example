using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cqrs.Hotel.Command;
using Cqrs.Hotel.Command.Infraestructure;
using Cqrs.Hotel.Command.Sagas.LeaveRoom;
using Cqrs.Hotel.Domain;
using Cqrs.Hotel.Domain.Events;
using Cqrs.Hotel.Domain.Events.LeftClientRoom;
using MediatR;

namespace Cqrs.Hotel.Infraestructure
{
    public class MemoryBus : IBus
    {
        private readonly IMediator _mediator;
        private readonly IDomainEventStore _domainEventStore;

        public MemoryBus(IMediator mediator,
            IDomainEventStore domainEventStore)
        {
            _mediator = mediator;
            _domainEventStore = domainEventStore;
        }

        public Task<TResponse> Send<TCommand, TResponse>(TCommand command) where TCommand : IDomainCommand<TResponse>
        {
            return _mediator.Send(command);
        }

        public void RaiseEvent<T>(T @event) where T : DomainEvent
        {
            _mediator.Publish(@event);
        }
    }
}


