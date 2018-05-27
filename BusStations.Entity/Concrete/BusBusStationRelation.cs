using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusStations.Core.Abstract;

namespace BusStations.Entity.Concrete
{
    public class BusBusStationRelation : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int BusId { get; set; }

        [ForeignKey("BusId")]
        public virtual Bus Bus { get; set; }

        public int BusStationId { get; set; }

        [ForeignKey("BusStationId")]
        public virtual BusStation BusStation { get; set; }

        public int StationIndex { get; set; }

        public bool IsLastLocateStation { get; set; }

        public TimeSpan LocatedTime { get; set; }

        public int Count { get; set; }

        public TimeSpan Avarage { get; set; }
    }
}