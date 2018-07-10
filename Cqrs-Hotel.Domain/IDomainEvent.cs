using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Cqrs.Hotel.Domain
{
    public interface IDomainEvent : INotification
    {
        DateTime TimeStamp { get; }
    }
   
}