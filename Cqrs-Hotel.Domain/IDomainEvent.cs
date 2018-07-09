using System;
using MediatR;

namespace Cqrs.Hotel.Domain
{
    public interface IDomainEvent : INotification
    {
        DateTime TimeStamp { get; }
    }
}