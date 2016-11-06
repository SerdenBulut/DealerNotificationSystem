using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.UnitOfWorkBase.Interface
{

    public interface IBusinessUnit
    {
    }

    public interface IBusinessUnit<TEntity, in TKey> : IBusinessUnit where TEntity : IEntity<TKey>
    {
        Task Delete(TKey id);
        Task<TEntity> Get(TKey id);
        Task<TEntity> GetNoTracking(TKey id);
        IQueryable<TEntity> List(params Expression<Func<TEntity, object>>[] membersToExpand);
        IQueryable<TEntity> ListNoTracking(params Expression<Func<TEntity, object>>[] membersToExpand);
        //Task<int> Save(IEnumerable<> );
    }
}
