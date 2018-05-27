using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BusStations.Core.Abstract;

namespace BusStations.Entity.Concrete
{
    public class BusStation : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal LocationX { get; set; }

        public decimal LocationY { get; set; }

        public virtual ICollection<BusBusStationRelation> StationOnBus { get; set; }

    }
}