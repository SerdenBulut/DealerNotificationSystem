using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Core.UnitOfWorkBase.Interface;

namespace DNS.WebApi.Code
{
    public abstract class DnsEntityController<TBusinessUnit, DTO, TKey> : EntityController<TBusinessUnit, DTO, TKey>
        where TBusinessUnit : IBusinessUnit<DTO, TKey>
        where DTO : IEntity<TKey>
    {
        protected DnsEntityController(TBusinessUnit businessUnit) : base(businessUnit)
        {
            
        }
        public override Task Delete(TKey id)
        {
            throw new NotImplementedException();
        }

        public override Task<DTO> Get(TKey id)
        {
            throw new NotImplementedException();
        }

        public override Task<DTO> GetNoTracking(TKey id)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<DTO> List()
        {
            throw new NotImplementedException();
        }

        public override IQueryable<DTO> ListNoTracking()
        {
            throw new NotImplementedException();
        }

        public override Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}