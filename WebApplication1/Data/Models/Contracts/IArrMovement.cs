using System;

namespace BMS.Data.Models.Contracts
{
    public interface IArrMovement
    {
        public string FlightNumber { get; }

        public DateTime DateOfMovement { get; }

        public DateTime TouchdownTime { get; }

        public DateTime OnBlockTime { get; set; }

        public string SupplementaryInformation { get; }


    }
}
