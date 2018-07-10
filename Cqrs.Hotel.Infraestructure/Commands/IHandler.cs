using MediatR;

namespace Cqrs.Hotel.Infraestructure.Commands
{
    public interface IHandler<in TCommand,TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : IRequest<TResponse>
    {
    }
}