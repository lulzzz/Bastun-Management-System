namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
   
    public class ArrivalMovement : IArrMovement
    {
        public string FlightNumber { get; }

        public DateTime DateOfMovement { get; }

        public DateTime TouchdownTime { get; }

        public DateTime OnBlockTime { get; set; }

        public string SupplementaryInformation { get; set; }
    }
}
