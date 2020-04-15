namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts.MovementContracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class ArrivalMovement : IArrivalMovement
    {
        public int Id { get; set; }

        public int InboundFlightId { get; set; }

        public virtual InboundFlight InboundFlight { get; set; }

        public DateTime DateOfMovement { get; set; }

        public DateTime TouchdownTime { get; set; }

        public DateTime OnBlockTime { get; set; }

        public string SupplementaryInformation { get; set; }
    }
}
