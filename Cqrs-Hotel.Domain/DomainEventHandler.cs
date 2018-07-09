using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Cqrs.Hotel.Domain
{
    public abstract class DomainEventHandler<TDomainEvent> :  IDomainEventHandler<TDomainEvent> where TDomainEvent : IDomainEvent, INotification
    {

        public abstract Task Handle(TDomainEvent @event, CancellationToken cancellationToken = default(CancellationToken));

        public DomainEventHandler()
        {

        }
    }
}