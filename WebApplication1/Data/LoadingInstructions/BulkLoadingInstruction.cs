namespace BMS.Data.LoadingInstructions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class BulkLoadingInstruction : LoadingInstruction
    {
        //bulk means that the aircraft is going to be loaded manually without containers, suitcases only
        public int HoldOnePieces { get; set; }

        public int HoldTwoPieces { get; set; }

        public int HoldThreePieces { get; set; }

        public int HoldFourPieces { get; set; }

        public int HoldFivePieces { get; set; }
    }
}
