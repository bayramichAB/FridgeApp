using FridgeApp_API.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using FridgeApp_API.Contracts;
using FridgeApp_API.Models;

namespace FridgeApp_API.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApiDbContext _Context;
        public RepositoryBase(ApiDbContext Context)
        => _Context = Context;

        public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges ? _Context.Set<T>().AsNoTracking() : _Context.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges) => !trackChanges ? _Context.Set<T>().Where(expression)
        .AsNoTracking() : _Context.Set<T>().Where(expression);

        public void Create(T entity) => _Context.Set<T>().Add(entity);
        public void Update(T entity) => _Context.Set<T>().Update(entity);
        public void Delete(T entity) => _Context.Set<T>().Remove(entity);
    }

}
