namespace BMS.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class Container
    {
        public Container()
        {
            
        }

        [Key]
        public int ContainerId { get; set; }

        public string ContainerType { get; set; }

        public int InboundFlightId { get; set; }

        public virtual InboundFlight InboundFlight { get; set; }

        public int OutboundFlightId { get; set; }

        public virtual OutboundFlight OutboundFlight { get; set; }

        public string ContainerPosition { get; set; }

        public string ContainerNumber { get; set; }

        public int ContainerPieces { get; set; }

        public double TotalContainerWeight { get; set; }

      
    }
}
