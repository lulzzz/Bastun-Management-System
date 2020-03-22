using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.Contracts.Movements
{
    public interface IArrivalMovement
    {
        public DateTime TouchdownTime { get; }

        public DateTime OnBlockTime { get; }

        public int DelayOnArrival { get; }

        public string SupplementalInformation { get; }

       
    }
}
