namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts;
    using BMS.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using BMS.GlobalData;

    public class Flight : IFlight
    {
      
        [Key]
        [Required]
        [RegularExpression(FlightInputDataValidation.FlightNumberValidation)]
        public string FlightNumber { get; }

        [Required]
        public AircraftType ACType { get; set; }

        [Required]
        [RegularExpression(FlightInputDataValidation.AircraftRegistrationValidation)]
        public string AircraftRegistration { get; set; }

        [Required]
        public string Origin { get; }

        [Required]
        public string Destination { get; }

        [Required]
        public DateTime STA { get; set; }

        [Required]
        public DateTime STD { get; set; }

        [Required]
       
        public int BookedPax { get; set; }
    }
}
