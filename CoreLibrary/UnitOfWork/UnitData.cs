using CoreLibrary.Data;
using CoreLibrary.Repository;
using System.Data.Entity;

namespace CoreLibrary.UnitOfWork
{
    public abstract class UnitData<T, TContext> : Repository<T, TContext>, IUnitData where T : EntityBase where TContext : DbContext, new()
    {
        public UnitData(TContext dbContext) : base(dbContext)
        {
        }
    }
}
