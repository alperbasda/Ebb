using BusStations.Business.Abstract;
using BusStations.Entity.Concrete;

namespace BusStations.Business.Concrete
{
    public class BusStationLayer : CrudLayerBase<BusStation> , IBusStationLayer
    {
        private BusStation _station;
        public BusStationLayer(BusStation station)
        {
            _station = station;
        }
        public void SetBusStationLocation(decimal x, decimal y)
        {  
            _station.LocationX = x;
            _station.LocationY = y;
            Update(_station);
        }

        public decimal[] GetBusStationLocation()
        {
            
            return new[] {_station.LocationX,_station.LocationY };
        }
    }
}