using System;
using Cqrs.Hotel.Domain.Model;

namespace Cqrs.Hotel.Data
{
    public interface IClientRepository
    {
        Cliente GetById(Guid id);
    }
}