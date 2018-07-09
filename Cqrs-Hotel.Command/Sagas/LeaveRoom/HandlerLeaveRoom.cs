using System.Threading;
using System.Threading.Tasks;
using Cqrs.Hotel.Command.Infraestructure;

namespace Cqrs.Hotel.Command.Sagas.LeaveRoom
{
    public class HandlerLeaveRoom : DomainCommandHandler<LeaveRoomCommand, bool>
    {
        public HandlerLeaveRoom()
        {

        }
        public override Task<bool> Handle(LeaveRoomCommand request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult<bool>(true);
        }
    }
}