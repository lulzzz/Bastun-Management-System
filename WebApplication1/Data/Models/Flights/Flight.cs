namespace BMS.Data.Models.Flights
{
    using BMS.Data.Models.Contracts.FlightContracts;
    using BMS.GlobalData;
    using BMS.GlobalData.ErrorMessages;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public abstract class Flight : IFlight
    {
        [Key]
        public int FlightId { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.FlightNumberRequired)]
        [RegularExpression(FlightInputDataValidation.GeneralFlightNumberValidation, ErrorMessage = InvalidErrorMessages.InvalidFlightNumberFormat)]
        public string FlightNumber { get; set; }
    }
}
