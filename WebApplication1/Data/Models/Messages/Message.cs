namespace BMS.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public  abstract class Message
    {

        

        public string FlightNumber { get; set; }

        public string AircraftRegistration { get; set; }

        public DateTime DateOfMessage { get; set; }

        public string Version { get; set; }

        public string Station { get; set; }
    }
}
