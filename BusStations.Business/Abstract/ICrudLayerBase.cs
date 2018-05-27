using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using BusStations.Core.Abstract;

namespace BusStations.Business.Abstract
{
    public interface ICrudLayerBase<T> where T : class,IEntity,new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Get(Expression<Func<T, bool>> filter, int skip);
        int Count(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        bool Delete(T entity);
    }
}