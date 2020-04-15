namespace BMS.Data.Models.Contracts.FlightContracts
{
    using BMS.Data.Models.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IInbound
    {
        public ArrivalMovement ArrivalMovement { get; set; }


        public ICollection<Container> InboundContainers { get; set; }

        public ICollection<Message> InboundMessages { get; set; }

        public string Origin { get; set; }
    }
}
