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
            this.Passengers = new List<Passenger>();
            this.DetermineCabinCapacity();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int AircraftId { get; set; }

        [Required]
        public virtual Aircraft Aircraft { get; set; }

        public virtual ICollection<Passenger> Passengers { get; set; }

        public int ZoneAlphaCapacity { get; set; }

        public int ZoneBravoCapacity { get; set; }

        public int ZoneCharlieCapacity { get; set; }

        public int ZoneDeltaCapacity { get; set; }

        private void DetermineCabinCapacity()
        {
            if (this.Aircraft.Type.ToString() == "A320")
            {
                this.ZoneAlphaCapacity = 60;
                this.ZoneBravoCapacity = 60;
                this.ZoneCharlieCapacity = 60;
            } 
            else if(this.Aircraft.Type.ToString() == "B737")
            {
                this.ZoneAlphaCapacity = 60;
                this.ZoneBravoCapacity = 60;
                this.ZoneCharlieCapacity = 60;
                this.ZoneDeltaCapacity = 9;
            }
        }

    }
}
