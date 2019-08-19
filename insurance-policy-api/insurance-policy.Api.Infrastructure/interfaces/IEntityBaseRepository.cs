using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace insurance_policy.Api.Infrastructure.interfaces
{
    public interface IEntityBaseRepository<T>
    {
        void Add(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        void Commit();
    }
}
