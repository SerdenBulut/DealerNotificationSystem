using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.UnitOfWorkBase.Interface;
using Dns.DbContext;

namespace Dns.Data.Interface
{
    public interface IDealerDataUnit : IDnsDataUnit<Dealer, int>
    {
    }
}
