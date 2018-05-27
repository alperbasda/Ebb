using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using BusStations.Business.Concrete;
using BusStations.Entity.Concrete;

namespace BusStations.Wcf.JsonService
{
    public class UpdateMonitor : IUpdateMonitor
    {
        private static JavaScriptSerializer _serializer;
        private static CrudLayerBase<BusStation> _busStationLayer;
        public UpdateMonitor()
        {
            if (_serializer==null) _serializer = new JavaScriptSerializer();
            if (_busStationLayer == null)_busStationLayer = new CrudLayerBase<BusStation>();
        }
        public string Update(int stationId)
        {
            BusStation station = _busStationLayer.Get(s => s.Name == "3464");
            List<ComplexClass> data = new List<ComplexClass>();
            foreach (BusBusStationRelation busBusStationRelation in station.StationOnBus)
            {
                ComplexClassBuilder complexClassBuilder = new ComplexClassBuilder(station);
                data.Add(complexClassBuilder.SetBus(busBusStationRelation.Bus).SetLeftTime().GetData());
            }
            return _serializer.Serialize(data);
        }
    }
}
