namespace BMS.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class FuelForm
    {
        public int Id { get; set; }

        public int OutboundFlightId { get; set; }

        [Required]
        public OutboundFlight OutboundFlight { get; set; }

        [Required]
        public string PilotInCommand { get; set; }

        [Required]
        public string CrewConfiguration { get; set; }

        [Required]
        public double TaxiFuel { get; set; }

        [Required]
        public double BlockFuel { get; set; }

        [Required]
        public double TripFuel { get; set; }

        [Required]
        public double DryOperatingWeight { get; set; }

        [Required]
        public double DryOperatingIndex { get; set; }
    }
}
