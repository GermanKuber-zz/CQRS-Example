using System;
using Cqrs.Hotel.Command.Infraestructure;

namespace Cqrs.Hotel.Command.Commands.LeaveRoom
{
    public class LeaveRoomCommand : DomainCommand<bool>
    {
        public Guid BookingId { get; set; }

        public LeaveRoomCommand(Guid bookingId)
        {
            BookingId = bookingId;
        }
    }
}