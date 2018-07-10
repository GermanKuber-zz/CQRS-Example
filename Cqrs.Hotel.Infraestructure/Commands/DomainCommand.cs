using System;

namespace Cqrs.Hotel.Infraestructure.Commands
{
    public class DomainCommand : IDomainCommand
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}