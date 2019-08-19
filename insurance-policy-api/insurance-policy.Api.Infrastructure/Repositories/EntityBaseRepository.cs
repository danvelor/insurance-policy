using insurance_policy.Api.Infrastructure.Data;
using insurance_policy.Api.Infrastructure.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace insurance_policy.Api.Infrastructure.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
       where T : class, new()
    {
        public InsuranceContext Context { get; set; }

        #region Constructor

        public EntityBaseRepository(InsuranceContext context)
        {
            Context = context;
        }
        #endregion
        #region Functions
        public virtual void Add(T entity)
        {
            var entitySet = Context.Set<T>();
            entitySet.Add(entity);
        }
        public virtual IQueryable<T> GetAll()
        {
            var entitySet = Context.Set<T>();
            return entitySet.AsQueryable();
        }
        public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }
        public virtual void Commit()
        {
            Context.SaveChanges();
        }

        #endregion
    }
}
