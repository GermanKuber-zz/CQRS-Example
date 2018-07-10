using System;
using MediatR;

namespace Cqrs.Hotel.Infraestructure.Commands
{
    public interface IDomainCommand<TResponse> : IRequest<TResponse>
    {
        Guid Id { get; }
    }
}