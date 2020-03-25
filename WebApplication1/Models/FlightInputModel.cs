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
        [Required]
        [RegularExpression(FlightInputDataValidation.FlightNumberValidation, ErrorMessage = (InvalidErrorMessages.FlightNumber))]
        public string FlightNumber { get; set; }

        [Required]
        [RegularExpression(FlightInputDataValidation.AircraftRegistrationValidation, ErrorMessage =(InvalidErrorMessages.AircraftRegistration))]
        public string AircraftRegistration { get; set; }

        [Required]
        public AircraftType ACType { get; set; }

        [Required]
        [RegularExpression(FlightInputDataValidation.AircraftVersionValidation, ErrorMessage = (InvalidErrorMessages.AircraftVersion))]
        public string Version { get; set; }


        [Required]
        [StringLength(3, ErrorMessage = InvalidErrorMessages.Origin)]
        public string Origin { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = InvalidErrorMessages.Destination)]
        public string Destination { get; set; }

        public DateTime STA { get; set; }

        public DateTime STD { get; set; }

        [Required]
        [Range(0, 189, ErrorMessage = (InvalidErrorMessages.BookedPax))]
        public int BookedPax { get; set; }
    }
}
