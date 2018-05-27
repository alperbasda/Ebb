using System;
using BusStations.Entity.Concrete;

namespace BusStations.Business.Abstract
{
    public interface IComplexClassBuilder
    {
        IComplexClassBuilder SetBus(Bus bus);
        IComplexClassBuilder SetLeftTime();
        ComplexClass GetData();
    }
}