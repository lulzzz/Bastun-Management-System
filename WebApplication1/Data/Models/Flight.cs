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
    using BMS.GlobalData.ErrorMessages;

    public class Flight : IFlight
    {

        public Flight()
        {
            this.Passengers = new List<Passenger>();
        }


        public int FlightId { get; set; }

        public string FlightNumber { get; set; }

        [Required]
        public AircraftType ACType { get; set; }

        [Required]
        [RegularExpression(FlightInputDataValidation.AircraftRegistrationValidation,ErrorMessage =(InvalidErrorMessages.AircraftRegistration))]
        public string AircraftRegistration { get; set; }

        [Required]
        [RegularExpression(FlightInputDataValidation.AircraftVersionValidation, ErrorMessage = (InvalidErrorMessages.AircraftVersion))]
        public string Version{ get; set; }

        [Required]
        [StringLength(3,ErrorMessage = InvalidErrorMessages.Origin)]
        public string Origin { get; set; }

        [Required]
        [StringLength(3, ErrorMessage =InvalidErrorMessages.Destination)]
        public string Destination { get; set; }

        [Required]
        public DateTime STA { get; set; }

        [Required]
        public DateTime STD { get; set; }
        
        

        [Required]
        public ICollection<Passenger> Passengers { get; set; }

        [Required]
        [Range(0,189,ErrorMessage =(InvalidErrorMessages.BookedPax))]
        public int BookedPax { get; set; }
    }
}
