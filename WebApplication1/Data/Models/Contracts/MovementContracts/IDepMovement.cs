namespace BMS.Data.Models.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IDepMovement
    {
        public int Id { get; set; }

        public int FlightRef { get; set; }

        public Flight Flight { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime OffBlockTime { get; set; }

        public DateTime TakeoffTime { get; set; }

        public int TotalPAX { get; set; }

        public string SupplementaryInformation { get; set; }

    }
}
