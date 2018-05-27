using System;
using BusStations.Entity.Concrete;

namespace BusStations.Business.BusState.Abstract
{
    interface ICalculateAvarage
    {
        void SetState(IState state);
        TimeSpan Calculate(BusStation station);
        TimeSpan CalculateNextStation();
        TimeSpan CalculateFrontStation(int stationIndex);
        TimeSpan CalculateFrontFullStation();
    }
}
