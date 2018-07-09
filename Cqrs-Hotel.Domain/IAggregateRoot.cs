using System;

namespace Cqrs.Hotel.Domain
{
    public interface IAggregateRoot
    {
        Guid Id { get; } 
    }
}