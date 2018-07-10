using Cqrs.Hotel.Domain;

namespace Cqrs.Hotel.Infraestructure
{
    public interface IDomainEventRepository
    {
        void Add(DomainEvent @event);
    }
}