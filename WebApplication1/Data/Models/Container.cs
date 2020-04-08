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

        public int OutboundFlightId { get; set; }

        public virtual OutboundFlight OutboundFlight { get; set; }

        public int ContainerInfoId { get; set; }

        public virtual ContainerInfo ContainerInfo { get; set; }
        public int ContainerPieces { get; set; }
      
    }
}
