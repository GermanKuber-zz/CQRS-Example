using System.Threading.Tasks;
using Cqrs.Hotel.Domain;
using MediatR;

namespace Cqrs.Hotel.Infraestructure
{
    public class MemoryBus : IBus
    {
        private readonly IMediator _mediator;
        private readonly IDomainEventRepository _eventRepository;

        public MemoryBus(IMediator mediator,
            IDomainEventRepository eventRepository)
        {
            _mediator = mediator;
            _eventRepository = eventRepository;
        }

        public void Send<TCommand>(TCommand command) where TCommand : Commands.IDomainCommand
        {
            _mediator.Send(command);
        }

        public void RaiseEvent<T>(T @event) where T : DomainEvent
        {
            _mediator.Publish(@event);
            _eventRepository.Add(@event);
        }
    }
}


