using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.UnitOfWorkBase.Interface;

namespace Core.UnitOfWorkBase.IBase
{
    public abstract class BusinessUnitBase<TDUnit, TEntity, TKey> : IDnsBusinesUnit<TDUnit, TEntity, TKey>, IDnsBusinesUnit
        where TDUnit : IDataUnit<TEntity, TKey>
        where TEntity : IEntity<TKey>
    {
        protected BusinessUnitBase(TDUnit dataUnit)
        {
            this.DataDunit = dataUnit;
        }
        public TDUnit DataDunit { get; }

        public abstract Task Delete(TKey id);
        public abstract Task<TEntity> Get(TKey id);
        public abstract Task<TEntity> GetNoTracking(TKey id);
        public abstract IQueryable<TEntity> List(params Expression<Func<TEntity, object>>[] membersToExpand);
        public abstract IQueryable<TEntity> ListNoTracking(params Expression<Func<TEntity, object>>[] membersToExpand);
    }
}
