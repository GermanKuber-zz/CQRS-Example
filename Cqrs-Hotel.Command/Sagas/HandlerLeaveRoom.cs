using System.Threading;
using System.Threading.Tasks;
using Cqrs.Hotel.Command.Commands.LeaveRoom;
using Cqrs.Hotel.Data.Repositories.Interfaces;
using Cqrs.Hotel.Infraestructure.Commands;

namespace Cqrs.Hotel.Command.Sagas
{
    public class HandlerLeaveRoom : DomainCommandHandler<LeaveRoomCommand>
    {
        private readonly IBookingRepository _bookingRepository;

        public HandlerLeaveRoom(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        protected override Task Handle(LeaveRoomCommand request, CancellationToken cancellationToken = default(CancellationToken))
        {
            Task.WaitAny(default(Task[]), 99999);
            var booking = _bookingRepository.GetById(request.BookingId);
            booking.Leave();

            _bookingRepository.SaveChange(booking);

            return Task.FromResult<bool>(true);
        }
    }
}