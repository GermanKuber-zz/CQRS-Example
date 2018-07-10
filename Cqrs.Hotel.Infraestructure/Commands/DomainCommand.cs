using System;

namespace Cqrs.Hotel.Infraestructure.Commands
{
    public class DomainCommand<TResponse> : IDomainCommand<TResponse>
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}