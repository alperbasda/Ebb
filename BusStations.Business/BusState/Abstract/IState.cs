using System;
using BusStations.Entity.Concrete;

namespace BusStations.Business.BusState.Abstract
{
    public interface IState
    {
        void ChangeDirection();
        TimeSpan CalculateNextStation();
        TimeSpan CalculateFrontFullStation();
        TimeSpan CalculateFrontStation(int stationIndex);
    }

}