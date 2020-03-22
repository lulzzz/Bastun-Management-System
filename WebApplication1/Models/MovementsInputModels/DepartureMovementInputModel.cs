using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.MovementsInputModels
{
    public class DepartureMovementInputModel
    {
        public DateTime OffBlockTime { get; set; }

        public DateTime TakeoffTime { get; }

        public DateTime ETA { get; }

        public string SupplementaryInformation { get; set; }

        public int PaxOnBoard { get; set; }
    }
}
