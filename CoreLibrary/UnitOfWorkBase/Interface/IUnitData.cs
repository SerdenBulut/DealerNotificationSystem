using System.Linq;
using System.Threading.Tasks;

namespace Core.UnitOfWorkBase.Interface
{
    public interface IDataUnit
    {
        
    }

    public interface IDataUnit<TEntity, in TKey> : IDataUnit where TEntity : IEntity<TKey>
    {
        Task Delete(TKey id);
        Task<TEntity> Get(TKey id);
        Task<TEntity> GetNoTracking(TKey id);
        IQueryable<TEntity> List();
        IQueryable<TEntity> ListNoTracking();
        Task<int> SaveChanges();
    }
}
