using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Cqrs.Hotel.Infraestructure.Commands
{
    public abstract class DomainCommandHandler<TCommand> : AsyncRequestHandler<TCommand>,IHandler<TCommand> where TCommand : IRequest
    {

        public DomainCommandHandler()
        {
            
        }

        protected abstract override Task Handle(TCommand request, CancellationToken cancellationToken = default(CancellationToken) );
    }

   
}