using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Cqrs.Hotel.Command.Infraestructure
{
    public abstract class DomainCommandHandler<TCommand,TResponse> : IHandler<TCommand,TResponse> where TCommand : IRequest<TResponse>
    {

        public DomainCommandHandler()
        {
            
        }

        public abstract Task<TResponse> Handle(TCommand request, CancellationToken cancellationToken = default(CancellationToken) );
    }

   
}