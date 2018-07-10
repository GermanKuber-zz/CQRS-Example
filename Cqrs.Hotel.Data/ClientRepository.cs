using System;
using Cqrs.Hotel.Domain.Model;

namespace Cqrs.Hotel.Data
{
    public class ClientRepository : IClientRepository
    {
        public Cliente GetById(Guid id) => new Cliente("Germán", "Küber");
    }
}
