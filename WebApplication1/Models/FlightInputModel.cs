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

        [Required(ErrorMessage = InvalidErrorMessages.HandlingStationIsRequired)]
        [RegularExpression(FlightInputDataValidation.StationValidation, ErrorMessage = InvalidErrorMessages.HandlingStationIsInvalid)]
        public string HandlingStation { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.DestinationRequired)]
        [RegularExpression(FlightInputDataValidation.StationValidation, ErrorMessage = InvalidErrorMessages.Destination)]
        public string Destination { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.FlightSTAIsRequired)]
        public DateTime STA { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.FlightSTDIsRequired)]
        public DateTime STD { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.BookedPAXRequired)]
        [Range(1,345, ErrorMessage = InvalidErrorMessages.BookedPax)]
        public int BookedPax { get; set; }
    }
}
