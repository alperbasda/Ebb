using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using BusStations.Core.Abstract;
using BusStations.Core.DataAccess;

namespace BusStations.Core.EntityFramework
{
    public class EfEntityRepositoryBase <T,TContext> : IEntityBaseRepository<T> where T:class ,IEntity,new()
    where TContext : DbContext
    {
        protected TContext Context;

        public EfEntityRepositoryBase()
        {
            Context = Activator.CreateInstance<TContext>();
        }
        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? Context.Set<T>().ToList() : Context.Set<T>().Where(filter).ToList();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return Context.Set<T>().FirstOrDefault(filter);
        }

        public T Get(Expression<Func<T, bool>> filter, int skip)
        {
            return Context.Set<T>().OrderBy(s => s.Id).Where(filter).Skip(skip).FirstOrDefault();
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return filter != null ? Context.Set<T>().Count(filter) : Context.Set<T>().Count();
        }

        public T Add(T entity)
        {
            var addedEntity = Context.Entry(entity);
            addedEntity.State = EntityState.Added;
            Context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            Context.Set<T>().AddOrUpdate(entity);
            Context.SaveChanges();
            return entity;
        }

        public bool Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
            return true;
        }
    }
}