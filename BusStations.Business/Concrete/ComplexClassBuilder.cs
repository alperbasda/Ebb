using System;
using BusStations.Business.Abstract;
using BusStations.Business.BusState.Concrete;
using BusStations.Entity.Concrete;

namespace BusStations.Business.Concrete
{
    public class ComplexClassBuilder : IComplexClassBuilder
    {
        private ComplexClass _complexClass;
        private CalculateAvarage _calculateAvarage;
        private BusStation _station;
        public ComplexClassBuilder(BusStation station)
        {
            _station = station;
            _complexClass=new ComplexClass() {StationName = station.Name};
        }
        public IComplexClassBuilder SetBus(Bus bus)
        {
            _calculateAvarage = new CalculateAvarage(bus);
            _complexClass.BusColor = bus.Color;
            _complexClass.BusNumber = bus.Number;
            return this;
        }

        public IComplexClassBuilder SetLeftTime()
        {
            _complexClass.LeftTime = _calculateAvarage.Calculate(_station);
            return this;
        }

        public ComplexClass GetData()
        {
            _complexClass.LastJsonTime = _complexClass.LeftTime.ToString();
            return _complexClass;
        }
    }
}