
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using BusStations.Business.Abstract;
using BusStations.Entity.Concrete;

namespace BusStations.Business.Concrete
{
    public class BusLayer : CrudLayerBase<Bus> , IBusLayer
    {
        private Bus _bus;

        public BusLayer(Bus bus)
        {
            _bus = bus;
        }
        public void SetBusLocation(decimal x, decimal y)
        {
            _bus.LocationX = x;
            _bus.LocationY = y;
            Update(_bus);
        }

        public void SetDirection(bool value)
        {
            _bus.Direction = value;
            Update(_bus);
        }

        public decimal[] GetBusLocation()
        {
            return new[] {_bus.LocationX, _bus.LocationY};
        }
    }
}