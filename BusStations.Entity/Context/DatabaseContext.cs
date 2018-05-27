using System.Data.Entity;
using BusStations.Entity.Concrete;

namespace BusStations.Entity.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Bus> Busses { get; set; }

        public DbSet<BusStation> BusStations { get; set; }

        public DbSet<BusBusStationRelation> BusBusStationRelations { get; set; }

        public DatabaseContext()
            : base("BusStationsDb")
        {

        }
    }
}