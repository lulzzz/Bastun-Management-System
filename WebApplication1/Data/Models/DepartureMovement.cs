namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts.MovementContracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class DepartureMovement : IDepartureMovement
    {
        public int Id { get; set; }
       

        public DateTime DateOfMovement { get; set; }

        public DateTime OffBlockTime { get; set; }

        public DateTime TakeoffTime { get; set; }

        public int TotalPAX { get; set; }

        public string SupplementaryInformation { get; set; }
    }
}
