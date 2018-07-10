namespace Cqrs.Hotel.Data
{
    public interface IBaseRepository <in TEntity>
    {                                
        void SaveChange(TEntity booking);
    }
}