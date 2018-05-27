using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BusStations.Business.Abstract;
using BusStations.Core.Abstract;
using BusStations.Core.EntityFramework;
using BusStations.Entity.Context;

namespace BusStations.Business.Concrete
{
    public class CrudLayerBase<T> :ICrudLayerBase<T> where T:class,IEntity,new()
    {
        private EfEntityRepositoryBase<T, DatabaseContext> Context;

        public CrudLayerBase()
        {
             Context = new EfEntityRepositoryBase<T, DatabaseContext>();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            return Context.GetList(filter);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return Context.Get(filter);
        }

        public T Get(Expression<Func<T, bool>> filter, int skip)
        {
            return Context.Get(filter, skip);
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return Context.Count(filter);
        }

        public T Add(T entity)
        {
            return Context.Add(entity);
        }

        public T Update(T entity)
        {
            return Context.Update(entity);
        }

        public bool Delete(T entity)
        {
            return Context.Delete(entity);
        }
    }
}