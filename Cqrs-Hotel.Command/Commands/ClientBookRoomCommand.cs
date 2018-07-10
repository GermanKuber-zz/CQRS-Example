using System;
using Cqrs.Hotel.Infraestructure.Commands;

namespace Cqrs.Hotel.Command.Commands
{
    public class ClientBookRoomCommand : DomainCommand
    {
        public Guid ClientId { get; set; }
        public Guid RoomId { get; set; }

        public ClientBookRoomCommand(Guid clientId, Guid roomId)
        {
            ClientId = clientId;
            RoomId = roomId;
        }
    }
}