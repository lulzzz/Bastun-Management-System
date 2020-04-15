namespace BMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class FuelFormInputModel
    {
        [Required(ErrorMessage = "Flight number is required")]
        public string FlightNumber { get; set; }

        [Required(ErrorMessage = "Registration is required")]
        public string Registration { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Name of pilot in command is required")]
        public string PilotInCommand { get; set; }

        [Required(ErrorMessage = "Crew configuration is required")]
        public string CrewConfiguration { get; set; }

        [Required(ErrorMessage = "Taxi fuel is required")]
        public int TaxiFuel { get; set; }

        [Required(ErrorMessage = "Block fuel is required")]
        public int BlockFuel { get; set; }

        [Required(ErrorMessage = "Trip fuel is required")]
        public int TripFuel { get; set; }

        [Required(ErrorMessage = "Takeoff fuel is required")]
        public int TakeoffFuel { get; set; }

        [Required(ErrorMessage = "Dry operating weight is required")]
        public int DryOperatingWeight { get; set; }

        [Required(ErrorMessage = "Dry operating index is required")]
        public double DryOperatingIndex { get; set; }
    }
}
