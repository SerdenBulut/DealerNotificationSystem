using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dns.Business.Interface;
using Dns.DbContext;
using DNS.WebApi.Code;

namespace DNS.WebApi.Controllers
{
    public class DealerController : DnsEntityController<IDealerBusinessUnit, Dealer, int>
    {
        // GET: Dealer
        public DealerController(IDealerBusinessUnit businessUnit) : base(businessUnit)
        {

        }

        public IList<Dealer> GetDealers()
        {
            return this.BusinessUnit.ListNoTracking().ToList();
        }
    }
}