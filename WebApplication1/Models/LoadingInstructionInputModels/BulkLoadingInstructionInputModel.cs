namespace BMS.Models
{
    using BMS.GlobalData.LoadConstants;
    using BMS.GlobalData.ErrorMessages;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class BulkLoadingInstructionInputModel
    {
        //Dictates how many pieces of baggage are supposed to be in each baggage hold

        [Required(ErrorMessage = "Flight number is required")] 
        public string FlightNumber { get; set; }

        [Range(1, LIConstants.HoldOnePieces, ErrorMessage = InvalidLoadInstructionErrorMessages.HoldOneCapacityExceeded)]
        public int HoldOne { get; set; }

        [Range(1,LIConstants.HoldTwoPieces, ErrorMessage = InvalidLoadInstructionErrorMessages.HoldTwoCapacityExceeded)]
        public int HoldTwo { get; set; }

        [Range(1, LIConstants.HoldThreePieces, ErrorMessage = InvalidLoadInstructionErrorMessages.HoldThreeCapacityExceeded)]
        public int HoldThree { get; set; }

        [Range(1, LIConstants.HoldFourPieces, ErrorMessage = InvalidLoadInstructionErrorMessages.HoldFourCapacityExceeded)]
        public int HoldFour { get; set; }

        [Range(1, LIConstants.HoldFivePieces, ErrorMessage = InvalidLoadInstructionErrorMessages.HoldFiveCapacityExceeded)]
        public int HoldFive { get; set; }
    }
}
