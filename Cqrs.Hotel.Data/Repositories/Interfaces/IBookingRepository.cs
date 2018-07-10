using System;
using Cqrs.Hotel.Domain.Model;

namespace Cqrs.Hotel.Data.Repositories.Interfaces
{
    public interface IBookingRepository : IBaseRepository<Reserva>
    {
        Reserva GetById(Guid id);
    }
}