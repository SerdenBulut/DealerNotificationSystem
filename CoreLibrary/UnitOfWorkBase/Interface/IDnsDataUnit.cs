using System.Linq;

namespace Core.UnitOfWorkBase.Interface
{
    public interface IDnsDataUnit
    {
        object GetExisting(object entity);
    }

    public interface IDnsDataUnit<TEntity, in TKey> : IDataUnit<TEntity, TKey>, IDnsDataUnit where TEntity : class, IEntity<TKey>, new()
    {
        IQueryable<TItem> Query<TItem>(bool asNoTrancking) where TItem : class;
    }
}
