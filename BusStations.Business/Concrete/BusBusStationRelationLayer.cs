using System;
using BusStations.Business.Abstract;
using BusStations.Entity.Concrete;

namespace BusStations.Business.Concrete
{
    public class BusBusStationRelationLayer : CrudLayerBase<BusBusStationRelation>, IBusBusStationRelation
    {
        private BusBusStationRelation _relation;
        public BusBusStationRelationLayer(BusBusStationRelation relation)
        {
            _relation = relation;
        }
        public BusBusStationRelationLayer()
        {
            
        }
        public void SetIsLocated(bool value)
        {
            _relation.IsLastLocateStation = value;
            Update(_relation);
        }

        public void SetLocatedTime(TimeSpan span)
        {
            _relation.LocatedTime = span;
            Update(_relation);
        }

        public void SetCount()
        {
            _relation.Count = _relation.Count + 1;
            Update(_relation);
        }

        public void SetAvarage(TimeSpan span)
        {
            _relation.Avarage = span;
            Update(_relation);
        }

        public bool GetIsLocated()
        {
            return _relation.IsLastLocateStation;
        }

        public TimeSpan GetLocatedTime()
        {
            return _relation.LocatedTime;
        }

        public int GetCount()
        {
            return _relation.Count;
        }

        public TimeSpan GetAvarage()
        {
            return _relation.Avarage;
        }
    }
}