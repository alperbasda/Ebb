using System;
using System.Linq;
using BusStations.Business.BusState.Abstract;
using BusStations.Entity.Concrete;

namespace BusStations.Business.BusState.Concrete
{
    public class CalculateAvarage : ICalculateAvarage
    {
        private IState _state;
        private Bus _bus;
        public CalculateAvarage(Bus bus)
        {
            _bus = bus;
            _state = _bus.ReelDirection ? (IState)new DirectionRightState(_bus, this) : new DirectionLeftState(_bus, this);
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public TimeSpan Calculate(BusStation station)
        {
            int targetStationIndex = _bus.BusStations.First(s => s.BusStationId == station.Id).StationIndex;
            _bus.Direction = _bus.ReelDirection;

            TimeSpan span = CalculateNextStation();

            if (_bus.Direction)
            {
                int nextIndex = _bus.BusStations.First(s => s.IsLastLocateStation).StationIndex + 1;
                if (_bus.BusStations.First(s => s.IsLastLocateStation).StationIndex < targetStationIndex)
                {
                    span += CalculateFrontStation(targetStationIndex);
                    span -= _bus.BusStations.First(s => s.StationIndex == nextIndex).Avarage;
                }
                else if (_bus.BusStations.First(s => s.IsLastLocateStation).StationIndex > targetStationIndex)
                {
                    
                    span += TimeSpan.FromTicks(CalculateFrontFullStation().Ticks * 2);
                    span += _bus.BusStations.First(s => s.StationIndex == nextIndex).Avarage;
                    span += _bus.BusStations.First(s => s.IsLastLocateStation).Avarage;
                    SetState(new DirectionLeftState(_bus, this));
                    span += CalculateFrontStation(targetStationIndex);
                }
            }
            else
            {
                int nextIndex = _bus.BusStations.First(s => s.IsLastLocateStation).StationIndex - 1;
                if (_bus.BusStations.First(s => s.IsLastLocateStation).StationIndex > targetStationIndex)
                {
                    span += CalculateFrontStation(targetStationIndex);
                    span -= _bus.BusStations.First(s => s.StationIndex == nextIndex).Avarage;
                }
                else if (_bus.BusStations.First(s => s.IsLastLocateStation).StationIndex < targetStationIndex)
                {
                    
                    span += TimeSpan.FromTicks(CalculateFrontFullStation().Ticks * 2);
                    span += _bus.BusStations.First(s => s.StationIndex == nextIndex).Avarage;
                    span += _bus.BusStations.First(s => s.IsLastLocateStation).Avarage;
                    SetState(new DirectionRightState(_bus, this));
                    span += CalculateFrontStation(targetStationIndex);
                }

            }
            return span;
        }

        public TimeSpan CalculateNextStation()
        {
            return _state.CalculateNextStation();
        }

        public TimeSpan CalculateFrontStation(int stationIndex)
        {
            return _state.CalculateFrontStation(stationIndex);
        }

        public TimeSpan CalculateFrontFullStation()
        {
            return _state.CalculateFrontFullStation();
        }
    }
}
