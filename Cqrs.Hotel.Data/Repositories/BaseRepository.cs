using Cqrs.Hotel.Data.Repositories.Interfaces;
using Cqrs.Hotel.Domain;
using Cqrs.Hotel.Infraestructure;

namespace Cqrs.Hotel.Data
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        protected IBus Bus { get; }

        public BaseRepository(IBus bus)
        {
            Bus = bus;
        }
       
        public virtual void SaveChange(TEntity booking)
        {
            if (booking is IEventManager book)
            {
                book.RaiseEvents(@event =>
                {
                    Bus.RaiseEvent(@event);
                    return true;
                });
            }
        }
    }
}