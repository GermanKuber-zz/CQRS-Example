using System.Threading;
using System.Threading.Tasks;

namespace Cqrs.Hotel.Domain.Events.ClientBookedRoom
{
    public class ClientBookedRoomEventHandler : DomainEventHandler<ClientBookedRoomEvent>
    {
        public override Task Handle(ClientBookedRoomEvent @event, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult<bool>(true);

        }
    }
}
