using MediatR;

namespace Cqrs.Hotel.Infraestructure.Commands
{
    public interface IHandler<in TCommand> : IRequestHandler<TCommand> where TCommand : IRequest
    {
    }
}