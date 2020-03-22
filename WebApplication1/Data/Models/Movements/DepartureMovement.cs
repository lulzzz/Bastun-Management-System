namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DepartureMovement : IDepMovement
    {
        public string FlightNumber { get; }

        public DateTime DepartureDate { get; }

        public DateTime OffBlockTime { get; set; }

        public DateTime TakeoffTime { get; set; }

        public int TotalPAX { get; set; }
    }
}
