using System;

namespace BusStatations.Mvc.Models
{
    public class JsonData
    {
        public int Id { get; set; }

        public string BusNumber { get; set; }

        public string BusColor { get; set; }

        public string StationName { get; set; }

        public TimeSpan LeftTime { get; set; }

        public string LastJsonTime { get; set; }

    }
}