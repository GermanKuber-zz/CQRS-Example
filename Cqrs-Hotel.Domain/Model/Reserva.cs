using System;
using Cqrs.Hotel.Domain.Events;
using Cqrs.Hotel.Domain.Events.LeftClientRoom;

namespace Cqrs.Hotel.Domain.Model
{
    public class Reserva : AggregateRoot
    {
        public Cliente Client { get; }
        public Habitacion Room { get; }
        public ReservaStatus Status { protected get; set; }
        public DateTime Arrival { get; set; }

        public Reserva(Cliente client, Habitacion room)
        {
            Client = client;
            Room = room;
        }

        public void Leave()
        {
            Status = ReservaStatus.Leave;
            RaiseEvent(new LeftClientRoomEvent(Id, Client.Id));
        }

    }
}