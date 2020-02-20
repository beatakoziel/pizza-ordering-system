using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Slicesy.PizzaOrder.WebApi.Repositories.Implementations
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        EntityEntry<T> Create(T entity);
        EntityEntry<T> Update(T entity);
        void Delete(T entity);
    }
}