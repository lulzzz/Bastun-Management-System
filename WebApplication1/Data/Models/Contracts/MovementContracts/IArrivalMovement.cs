namespace BMS.Data.Models.Contracts.MovementContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IArrivalMovement
    {
        public int Id { get; set; }

       
        public DateTime DateOfMovement { get; set; }

        public DateTime TouchdownTime { get; set; }

        public DateTime OnBlockTime { get; set; }

        public string SupplementaryInformation { get; set; }
    }
}
