using System;
using Cqrs.Hotel.Data.Repositories.Interfaces;
using Cqrs.Hotel.Domain.Model;
using Cqrs.Hotel.Infraestructure;

namespace Cqrs.Hotel.Data
{
    public class BookingRepository : BaseRepository<Reserva>, IBookingRepository
    {
        public BookingRepository(IBus bus) : base(bus)
        {
        }

        public Reserva GetById(Guid id) => new Reserva(new Cliente("Germán", "Küber"), new Habitacion());

    }

 
}