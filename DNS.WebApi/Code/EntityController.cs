using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Core.UnitOfWorkBase.Interface;

namespace DNS.WebApi.Code
{
    public abstract class EntityController<TBusinessUnit, DTO, TKey> : EntityControllerBase
        where TBusinessUnit : IBusinessUnit<DTO, TKey>
        where DTO : IEntity<TKey>
    {
        protected EntityController(TBusinessUnit businessUnit)
        {
            this.BusinessUnit = businessUnit;
        }
        public TBusinessUnit BusinessUnit { get; }
        public abstract Task Delete(TKey id);
        public abstract Task<DTO> Get(TKey id);
        public abstract Task<DTO> GetNoTracking(TKey id);
        public abstract IQueryable<DTO> List();
        public abstract IQueryable<DTO> ListNoTracking();
        public abstract Task<int> SaveChanges();
    }
}