namespace BMS.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class FuelForm
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AircraftId { get; set; }

        [Required]
        public virtual Aircraft Aircraft { get; set; }

        [Required]
        public DateTime Date { get; set; }

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
        public int TakeoffFuel { get; set; }

        [Required]
        public double DryOperatingWeight { get; set; }

        [Required]
        public double DryOperatingIndex { get; set; }
    }
}
