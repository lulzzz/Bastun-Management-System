namespace BMS.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class AircraftCabin
    {
        public AircraftCabin()
        {
            this.ZoneAlpha = new List<Passenger>();
            this.ZoneBravo = new List<Passenger>();
            this.ZoneCharlie = new List<Passenger>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int AircraftId { get; set; }

        [Required]
        public Aircraft Aircraft { get; set; }

        public List<Passenger> ZoneAlpha { get; set; }

        public List<Passenger> ZoneBravo { get; set; }

        public List<Passenger> ZoneCharlie { get; set; }
    }
}
