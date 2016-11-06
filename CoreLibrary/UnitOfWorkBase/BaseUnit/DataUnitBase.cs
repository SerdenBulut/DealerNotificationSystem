using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Core.UnitOfWorkBase.Interface;

namespace Core.UnitOfWorkBase.IBase
{
    public abstract class DataUnitBase<TContext, TEntity, TKey> : IDataUnit<TEntity, TKey>, IDataUnit
        where TContext : DbContext, new()
        where TEntity : class, Interface.IEntity<TKey>, new()
    {
        protected DataUnitBase(TContext context)
        {
            this.Context = context;
        }
        protected TContext Context { get; }

        public abstract Task Delete(TKey id);
        public abstract Task<TEntity> Get(TKey id);
        public abstract Task<TEntity> GetNoTracking(TKey id);
        public abstract IQueryable<TEntity> List();
        public abstract IQueryable<TEntity> ListNoTracking();
        public abstract Task<int> SaveChanges();
    }
}
