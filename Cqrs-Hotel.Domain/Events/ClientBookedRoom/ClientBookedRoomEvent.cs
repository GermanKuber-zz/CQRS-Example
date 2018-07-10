using System;

namespace Cqrs.Hotel.Domain.Events.ClientBookedRoom
{
    public class ClientBookedRoomEvent : DomainEvent , IDomainEvent
    {
        public Guid ClientId { get; }
        public Guid RoomId { get; }
        public ClientBookedRoomEvent(Guid roomId, Guid clientId)
        {
            RoomId = roomId;
            ClientId = clientId;
        }
    }
}
