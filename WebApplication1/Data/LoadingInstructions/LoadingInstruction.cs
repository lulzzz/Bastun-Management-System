namespace BMS.Data.LoadingInstructions
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public abstract class LoadingInstruction
    {
        [Key]
        public int Id { get; set; }

        public int OutboundFlightId { get; set; }

        public virtual OutboundFlight? OutboundFlight { get; set; }
    }
}
