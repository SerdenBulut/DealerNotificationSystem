using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWorkBase.Interface
{
    public interface IDnsBusinesUnit
    {
        
    }
    public interface IDnsBusinesUnit<out TDunit, TEntity, in TKey> : IBusinessUnit<TEntity, TKey>, IDnsBusinesUnit
        where TDunit : IDataUnit<TEntity,TKey>
        where TEntity : IEntity<TKey>
    {
        TDunit DataDunit { get; }
    }
}
