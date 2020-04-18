using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Models.LoadingInstructionInputModels
{
    public class _788LoadingInstructionInputModel
    {

        public _788LoadingInstructionInputModel()
        {
            this.HoldOneLeft = new List<string>();
            this.HoldOneRight = new List<string>();
            this.HoldTwoLeft = new List<string>();
            this.HoldTwoRight = new List<string>();
            this.HoldThreeLeft = new List<string>();
            this.HoldFourLeft = new List<string>();
            this.HoldFourRight = new List<string>();
        }

        public string FlightNumber { get; set; }

        public ICollection<string> HoldOneLeft { get; set; }

        public ICollection<string> HoldOneRight { get; set; }

        public ICollection<string> HoldTwoLeft { get; set; }

        public ICollection<string> HoldTwoRight { get; set; }

        public ICollection<string> HoldThreeLeft { get; set; }

        public ICollection<string> HoldThreeRight { get; set; }

        public ICollection<string> HoldFourLeft { get; set; }

        public ICollection<string> HoldFourRight { get; set; }



    }
}
