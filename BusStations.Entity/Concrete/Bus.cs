using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BusStations.Core.Abstract;

namespace BusStations.Entity.Concrete
{
    public class Bus : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public string Color { get; set; }

        public decimal LocationX { get; set; }

        public decimal LocationY { get; set; }

        public bool Direction { get; set; }

        public bool ReelDirection { get; set; }

        public virtual ICollection<BusBusStationRelation> BusStations { get; set; }



    }
}
