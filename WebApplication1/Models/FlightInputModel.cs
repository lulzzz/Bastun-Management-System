namespace BMS.Models
{
    using BMS.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class FlightInputModel
    {
        public string FlightNumber { get; set; }

        public string AircraftRegistration { get; set; }

        public AircraftType ACType { get; set; }

        public string Version { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime STA { get; set; }

        public DateTime STD { get; set; }

        public int BookedPax { get; set; }
    }
}
