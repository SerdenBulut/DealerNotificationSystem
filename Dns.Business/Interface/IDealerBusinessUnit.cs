using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.UnitOfWorkBase.Interface;
using Dns.Data.Interface;
using Dns.DbContext;

namespace Dns.Business.Interface
{
    public interface IDealerBusinessUnit : IDnsBusinesUnit<IDealerDataUnit, Dealer, int>
    {
        IQueryable<Dealer> GetDealers();
    }
}
