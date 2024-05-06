using System;
using System.Linq.Expressions;
using FridgeApp_API.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FridgeApp_API.Contracts
{
    public interface IRepositoryBase <T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
