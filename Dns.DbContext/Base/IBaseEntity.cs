using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.UnitOfWorkBase.Interface;

namespace Dns.DbContext.Base
{
    public interface IBaseEntity : IEntity, IEntity<int>
    {
        DateTime CreateTime { get; set; }
        string CreatedBy { get; set; }
        DateTime UpdateTime { get; set; }
        string UpdatedBy { get; set; }
    }
}
