using System.Collections.Generic;
using Cqrs.Hotel.Domain.Events.ClientBookedRoom;

namespace Cqrs.Hotel.Domain.Model
{
    public class Habitacion : AggregateRoot
    {
        public List<Review> Reviews { get; } = new List<Review>();

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }

        public void Book(Cliente client)
        {
            RaiseEvent(new ClientBookedRoomEvent(Id, client.Id));
        }
    }
}