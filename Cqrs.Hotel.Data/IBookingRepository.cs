using System;
using Cqrs.Hotel.Domain.Model;

namespace Cqrs.Hotel.Data
{
    public interface IBookingRepository : IBaseRepository<Reserva>
    {
        Reserva GetById(Guid id);
    }

    public interface IBaseRepository <in TEntity>
    {                                
        void SaveChange(TEntity booking);
    }
}