using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.UnitOfWorkBase.IBase;
using Dns.Business.Interface;
using Dns.Data.Interface;
using Dns.DbContext;

namespace Dns.Business.BUnit
{
    public class DealerBusinessUnit : BusinessUnitBase<IDealerDataUnit, Dealer, int>, IDealerBusinessUnit
    {

        public DealerBusinessUnit(IDealerDataUnit dataUnit) : base(dataUnit)
        {
        }
        public override Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<Dealer> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Dealer> GetDealers()
        {
            return DataDunit.Query<Dealer>(true);
        }

        public override Task<Dealer> GetNoTracking(int id)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<Dealer> List(params Expression<Func<Dealer, object>>[] membersToExpand)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<Dealer> ListNoTracking(params Expression<Func<Dealer, object>>[] membersToExpand)
        {
            throw new NotImplementedException();
        }

    }
}
