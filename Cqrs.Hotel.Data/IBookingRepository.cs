using System;
using Cqrs.Hotel.Domain.Model;

namespace Cqrs.Hotel.Data
{
    public interface IBookingRepository : IBaseRepository<Reserva>
    {
        Reserva GetById(Guid id);
    }
}