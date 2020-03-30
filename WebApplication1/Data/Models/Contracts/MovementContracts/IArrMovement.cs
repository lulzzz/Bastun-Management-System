using System;

namespace BMS.Data.Models.Contracts
{
    public interface IArrMovement
    {
        public int Id { get; set; }

        public int FlightRef { get; set; }

        public Flight Flight { get; set; }

        public DateTime DateOfMovement { get; }

        public DateTime TouchdownTime { get; }

        public DateTime OnBlockTime { get; set; }

        public string SupplementaryInformation { get; }


    }
}
