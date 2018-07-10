using System;
using Cqrs.Hotel.Domain.Model;

namespace Cqrs.Hotel.Data
{
    public class BookingRepository : BaseRepository<Reserva>, IBookingRepository
    {
        public Reserva GetById(Guid id) => new Reserva(new Cliente("Germán", "Küber"), new Habitacion());

    }
}