using System;
using MediatR;

namespace Cqrs.Hotel.Command.Infraestructure
{
    public class DomainCommand<TResponse> : IDomainCommand<TResponse>
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}