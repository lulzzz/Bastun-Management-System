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
        public virtual Aircraft Aircraft { get; set; }

        public virtual List<Passenger> ZoneAlpha { get; set; }

        public virtual List<Passenger> ZoneBravo { get; set; }

        public virtual List<Passenger> ZoneCharlie { get; set; }
    }
}
