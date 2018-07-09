using System;
using MediatR;

namespace Cqrs.Hotel.Command.Infraestructure
{
    public interface IDomainCommand<TResponse> : IRequest<TResponse>
    {
        Guid Id { get; }
    }
}