using System;
using Cqrs.Hotel.Domain;
using Cqrs.Hotel.Domain.Model;

namespace Cqrs.Hotel.Data
{
    public class ClientRepository : IClientRepository
    {
        public Cliente GetById(Guid id) => new Cliente("Germán", "Küber");
    }

    public class BookingRepository : BaseRepository<Reserva>, IBookingRepository
    {
        public Reserva GetById(Guid id) => new Reserva(new Cliente("Germán", "Küber"), new Habitacion());

    }

    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
       
        public virtual void SaveChange(TEntity booking)
        {
            if (booking is IEventManager book)
            {
                book.RaiseEvents(x => { return true; });
            }
        }
    }
}
