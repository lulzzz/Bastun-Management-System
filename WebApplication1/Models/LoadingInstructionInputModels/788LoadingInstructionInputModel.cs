using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Models.LoadingInstructionInputModels
{
    public class _788LoadingInstructionInputModel
    {
        public string FlightNumber { get; set; }

        public ICollection<string> HoldOneLeft { get; set; }

        public ICollection<string> HoldOneRight { get; set; }

        public ICollection<string> HoldTwoLeft { get; set; }

        public ICollection<string> HoldTwoRight { get; set; }

      

    }
}
