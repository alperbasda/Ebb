using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusStations.Core.Abstract;

namespace BusStations.Entity.Concrete
{
    public class ComplexClass : IEntity
    {
        public int Id { get; set; }

        public string BusNumber { get; set; }

        public string BusColor { get; set; }

        public string StationName { get; set; }

        public TimeSpan LeftTime { get; set; }

        public string LastJsonTime { get; set; }




    }
}