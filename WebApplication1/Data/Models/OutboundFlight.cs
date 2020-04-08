namespace BMS.Data.Models
{
    using BMS.Data.Models.Messages;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class OutboundFlight
    {
        [Key]
        public int FlightId { get; set; }

        public string FlightNumber { get; set; }

        public int AircraftId { get; set; }

        public virtual Aircraft Aircraft { get; set; }

        public string HandlingStation { get; set; }

        public virtual ICollection<Message> OutboundMessages { get; set; }

        public virtual DepartureMovement DepartureMovement { get; set; }

        public DateTime STD { get; set; }

        public int BookedPax { get; set; }

        


    }
}
