using System;
using MediatR;

namespace Cqrs.Hotel.Domain.Events.LeftClientRoom
{
    public class LeftClientRoomEvent : DomainEvent , IDomainEvent
    {
        public Guid ClientId { get; }
        public Guid ReservationId { get; }
        public LeftClientRoomEvent(Guid reservationId, Guid clientId)
        {
            ReservationId = reservationId;
            ClientId = clientId;
        }
    }
}
