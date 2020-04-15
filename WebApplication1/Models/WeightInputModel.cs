namespace BMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class WeightFormInputModel
    {
        [Required(ErrorMessage = "Flight number is required")]
        public string FlightNumber { get; set; }

        [Required(ErrorMessage = "Aircraft basic weight is required")]
        public int AircraftBasicWeight { get; set; }

        [Required(ErrorMessage =  "Maximum zero fuel weight is required")]
        public int MaximumZeroFuelWeight { get; set; }

        [Required(ErrorMessage = "Maximum takeoff weight is required")]
        public int MaximumTakeoffWeight { get; set; }

        [Required(ErrorMessage = "Maximum landing weight is required")]
        public int MaximumLandingWeight { get; set; }
    }
}
