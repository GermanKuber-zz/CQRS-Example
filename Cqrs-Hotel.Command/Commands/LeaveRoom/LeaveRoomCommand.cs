using System;
using Cqrs.Hotel.Infraestructure.Commands;

namespace Cqrs.Hotel.Command.Commands.LeaveRoom
{
    public class LeaveRoomCommand : DomainCommand
    {
        public Guid BookingId { get; set; }

        public LeaveRoomCommand(Guid bookingId)
        {
            BookingId = bookingId;
        }
    }
}