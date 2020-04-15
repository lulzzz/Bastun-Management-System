namespace BMS.Data.Models.Contracts.FlightContracts
{
    using BMS.Data.Models.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IOutbound
    {
        public Aircraft Aircraft { get; set; }

        public string HandlingStation { get; set; }

        public string Destination { get; set; }

        public ICollection<Message> OutboundMessages { get; set; }

        public ICollection<Container> OutboundContainers { get; set; }

        public DepartureMovement DepartureMovement { get; set; }

        public int BookedPAX { get; set; }

        public bool IsDeparted { get; set; }
    }
}
