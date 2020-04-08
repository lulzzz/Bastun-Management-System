namespace BMS.Data.Models
{
    using BMS.Data.Models.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OutboundFlight
    {

        public int FlightId { get; set; }

        public string FlightNumber { get; set; }

        public int AircraftId { get; set; }

        public Aircraft Aircraft { get; set; }

        public string HandlingStation { get; set; }

        public ICollection<Message> OutboundMessages { get; set; }

        public DepartureMovement DepartureMovement { get; set; }

        public DateTime STD { get; set; }

        public int BookedPax { get; set; }

        


    }
}
