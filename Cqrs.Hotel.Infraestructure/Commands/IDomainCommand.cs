using System;
using MediatR;

namespace Cqrs.Hotel.Infraestructure.Commands
{
    public interface IDomainCommand : IRequest
    {
        Guid Id { get; }
    }
}