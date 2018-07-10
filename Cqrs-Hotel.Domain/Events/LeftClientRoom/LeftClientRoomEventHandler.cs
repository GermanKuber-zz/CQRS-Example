using System.Threading;
using System.Threading.Tasks;

namespace Cqrs.Hotel.Domain.Events.LeftClientRoom
{
    public class LeftClientRoomEventHandler : DomainEventHandler<LeftClientRoomEvent>
    {


        public override Task Handle(LeftClientRoomEvent notification, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult<bool>(true);
        }


    }
}
