using System;
using Cqrs.Hotel.Data.Repositories.Interfaces;
using Cqrs.Hotel.Domain.Model;
using Cqrs.Hotel.Infraestructure;

namespace Cqrs.Hotel.Data.Repositories
{
    public class ClientRepository : BaseRepository<Cliente>, IClientRepository
    {
        public ClientRepository(IBus bus) : base(bus)
        {
        }

        public Cliente GetById(Guid id) => new Cliente("Germán", "Küber");
    }
}
