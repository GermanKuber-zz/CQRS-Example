using Cqrs.Hotel.Domain;

namespace Cqrs.Hotel.Data
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
       
        public virtual void SaveChange(TEntity booking)
        {
            if (booking is IEventManager book)
            {
                book.RaiseEvents(x =>
                {
                   
                    return true;
                });
            }
        }
    }
}