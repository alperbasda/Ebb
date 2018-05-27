using System;
using System.Linq;
using BusStations.Business.BusState.Abstract;
using BusStations.Business.Concrete;
using BusStations.Entity.Concrete;

namespace BusStations.Business.BusState.Concrete
{
    public class DirectionRightState : IState
    {

        private BusStation _locatedStation;
        private int _locatedStationIndex;
        private Bus _bus;
        private BusLayer _layer;
        private CalculateAvarage _avarage;
        public DirectionRightState(Bus bus,CalculateAvarage avarage)
        {
            _bus = bus;
            _avarage = avarage;
            _layer = new BusLayer(_bus);
            _locatedStationIndex = _bus.BusStations.First(s => s.IsLastLocateStation).StationIndex;
            _locatedStation = _bus.BusStations.First(s => s.IsLastLocateStation).BusStation;
        }
        public void ChangeDirection()
        {
            _layer.SetDirection(false);
        }
        
        public TimeSpan CalculateNextStation()
        {
            TimeSpan span;
            if (_locatedStationIndex!=_bus.BusStations.Count-1)
            {
                span = _bus.BusStations.First(s => s.StationIndex == _locatedStationIndex + 1).Avarage-(DateTime.Now.TimeOfDay- _bus.BusStations.First(s => s.StationIndex == _locatedStationIndex).LocatedTime);
            }
            else
            {
                span = _bus.BusStations.First(s => s.StationIndex == _locatedStationIndex - 1).Avarage - (DateTime.Now.TimeOfDay - _bus.BusStations.First(s => s.StationIndex == _locatedStationIndex).LocatedTime);
                ChangeDirection();
                _avarage.SetState(new DirectionLeftState(_bus,_avarage));

            }
            return span;
        }

        
        public TimeSpan CalculateFrontFullStation()
        {
            TimeSpan result = new TimeSpan();
            _bus.BusStations.Where(s => s.StationIndex > _locatedStationIndex+1).ToList().ForEach(q=>result+=q.Avarage);
            return result;
        }

        public TimeSpan CalculateFrontStation(int stationIndex)
        {
            TimeSpan result = new TimeSpan();
            _bus.BusStations.Where(s => s.StationIndex > _locatedStationIndex && s.StationIndex <= stationIndex).ToList().ForEach(q => result += q.Avarage);
            return result;
        }

        
    }
}