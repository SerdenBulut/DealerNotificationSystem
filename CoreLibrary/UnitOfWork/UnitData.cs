using System.Data.Entity;
using Core.Data;
using Core.Repository;
using Core.UnitOfWork.Interface;

namespace Core.UnitOfWork
{
    public abstract class UnitData<T, TContext> : Repository<T, TContext>, IUnitData where T : EntityBase where TContext : DbContext, new()
    {
        public UnitData(TContext dbContext) : base(dbContext)
        {
        }
    }
}
