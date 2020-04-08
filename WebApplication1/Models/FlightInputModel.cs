namespace BMS.Models
{
    using BMS.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using BMS.GlobalData;
    using BMS.GlobalData.ErrorMessages;

    public class FlightInputModel
    {
        [Required(ErrorMessage = InvalidErrorMessages.FlightNumberRequired)]
        [RegularExpression(FlightInputDataValidation.FlightNumberValidation, ErrorMessage = InvalidErrorMessages.FlightNumber)]
        public string FlightNumber { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.OriginRequired)]
        [RegularExpression(FlightInputDataValidation.StationValidation,ErrorMessage =InvalidErrorMessages.Origin)]
        public string Origin { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.DestinationRequired)]
        [RegularExpression()]
        public string Destination { get; set; }
    }
}
