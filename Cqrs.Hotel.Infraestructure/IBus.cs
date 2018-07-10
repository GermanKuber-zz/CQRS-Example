using System.Threading.Tasks;
using Cqrs.Hotel.Domain;

namespace Cqrs.Hotel.Infraestructure
{
    public interface IBus
    {
        void Send<TCommand>(TCommand command)  where TCommand : Commands.IDomainCommand;

        void RaiseEvent<T>(T theEvent) where T : DomainEvent; 
    }
}
