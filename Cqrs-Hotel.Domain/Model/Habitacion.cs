using System.Collections.Generic;

namespace Cqrs.Hotel.Domain.Model
{
    public class Habitacion : AggregateRoot
    {
        public List<Review> Reviews { get; } = new List<Review>();

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }
    }
}