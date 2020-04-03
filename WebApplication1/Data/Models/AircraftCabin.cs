namespace BMS.Data.Models
{
    using System;
    using System.Collections.Generic;
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

        public List<Passenger> ZoneAlpha { get; set; }

        public List<Passenger> ZoneBravo { get; set; }

        public List<Passenger> ZoneCharlie { get; set; }
    }
}
