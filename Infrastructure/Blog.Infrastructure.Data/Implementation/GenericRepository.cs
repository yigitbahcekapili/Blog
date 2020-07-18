using Blog.Infrastructure.Data.Contract;
using Blog.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Blog.Infrastructure.Data.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase, new()
    {
        protected BlogDbContext DbContext { get; set; }

        public List<T> GetAll()
        {
            return DbContext.Set<T>().ToList();
        }

        /// <summary>
        /// Get entity by primary key
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            DbContext.Set<T>().Add(entity);

            DbContext.SaveChanges();
        }

        public ICollection<T> GetList()
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetList(Expression<Func<T, bool>> filter)
        {
            return DbContext.Set<T>().Where(filter).ToList();
        }

        /// <summary>
        /// Set 'IsActive' of the object false
        /// </summary>
        /// <param name="id">Primary key</param>
        public void Delete(int id)
        {
            T entity = DbContext.Set<T>().Find(id);

            entity.IsActive = false;

            Update(entity);
        }

        public void Update(T entity)
        {
            DbContext.Set<T>().Update(entity);

            DbContext.SaveChanges();
        }


    }
}
