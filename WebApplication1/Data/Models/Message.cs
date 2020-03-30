namespace BMS.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public  abstract class Message
    {
        protected Message(string flightNumber, string registration, DateTime dateOfMessage)
        {
            this.FlightNumber = flightNumber;
            this.AircraftRegistration = registration;
            this.DateOfMessage = dateOfMessage;
        }

        public string FlightNumber { get; set; }

        public string AircraftRegistration { get; set; }

        public DateTime DateOfMessage { get; set; }
    }
}
