namespace Cqrs.Hotel.Data.Repositories.Interfaces
{
    public interface IBaseRepository <in TEntity>
    {                                
        void SaveChange(TEntity booking);
    }
}