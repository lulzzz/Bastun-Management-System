using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.MovementsInputModels
{
    public class ArrivalMovementInputModel
    {
        public DateTime TouchdownTime { get; set; }

        public DateTime OnBlockTime { get; set; }

        public string SupplementaryInformation { get; set; }

        public DateTime DateOfMovement { get; set; }

        public string FlightNumber { get; set; }
    }
}
