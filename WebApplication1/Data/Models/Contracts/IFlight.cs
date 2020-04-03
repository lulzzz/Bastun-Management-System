namespace BMS.Data.Models.Contracts
{
    using BMS.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

   public interface IFlight
    {
        public string FlightNumber { get; }

        public AircraftType ACType { get; set; }

        public string AircraftRegistration { get; set; }

        public string Version { get; set; }

        public string Origin { get; }

        public string Destination { get; }

        public ArrivalMovement ArrivalMovement { get; set; }

        public DepartureMovement DepartureMovement { get; set; }

        //Scheduled Time Of Arrival
        public DateTime STA { get; }

        //Scheduled Time of Departure
        public DateTime STD { get; }

        //Number of booked passengers 
        public int BookedPax { get; }

        public ICollection<Passenger> Passengers { get; set; }
    }
}
