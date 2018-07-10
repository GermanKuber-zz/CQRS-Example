using System.Threading;
using System.Threading.Tasks;
using Cqrs.Hotel.Command.Commands;
using Cqrs.Hotel.Command.Commands.LeaveRoom;
using Cqrs.Hotel.Data.Repositories.Interfaces;
using Cqrs.Hotel.Infraestructure.Commands;

namespace Cqrs.Hotel.Command.Sagas
{
    public class HandlerClientBookRoom : DomainCommandHandler<ClientBookRoomCommand>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IRoomRepository _roomRepository;

        public HandlerClientBookRoom(IClientRepository clientRepository, IRoomRepository roomRepository)
        {
            _clientRepository = clientRepository;
            _roomRepository = roomRepository;
        }


        protected override Task Handle(ClientBookRoomCommand request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var client = _clientRepository.GetById(request.ClientId);
            var room = _roomRepository.GetById(request.RoomId);
            room.Book(client);
            return Task.FromResult<bool>(true);
        }
    }
}