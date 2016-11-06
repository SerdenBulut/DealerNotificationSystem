using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.UnitOfWorkBase;
using Core.UnitOfWorkBase.IBase;
using Dns.Data.Interface;
using Dns.DbContext;

namespace Dns.Data.DUnit
{
    public class DealerDataUnit : DataUnitBase<DNSEntities, Dealer, int>, IDealerDataUnit
    {
        public DealerDataUnit(DNSEntities context) : base(context)
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

        public object GetExisting(object entity)
        {
            throw new NotImplementedException();
        }

        public override Task<Dealer> GetNoTracking(int id)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<Dealer> List()
        {
            throw new NotImplementedException();
        }

        public override IQueryable<Dealer> ListNoTracking()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TItem> Query<TItem>(bool asNoTrancking) where TItem : class
        {
            throw new NotImplementedException();
        }

        public override Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
