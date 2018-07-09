using System.Net.NetworkInformation;
using MediatR;

namespace Cqrs.Hotel.Command.Infraestructure
{
    public interface IHandler<in TCommand,TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : IRequest<TResponse>
    {
    }
}