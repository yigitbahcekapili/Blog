using Blog.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Infrastructure.Data.Contract
{
    public interface IGenericRepository<T> where T : EntityBase, new()
    {
        ICollection<T> GetList();
        ICollection<T> GetList(Expression<Func<T, bool>> filter);
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
