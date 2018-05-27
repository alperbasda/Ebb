using System;

namespace BusStations.Business.Abstract
{
    public interface IBusBusStationRelation
    {
        void SetIsLocated(bool value);
        void SetLocatedTime(TimeSpan span);
        void SetCount();
        void SetAvarage(TimeSpan span);
        bool GetIsLocated();
        TimeSpan GetLocatedTime();
        int GetCount();
        TimeSpan GetAvarage();
    }
}