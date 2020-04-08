namespace BMS.Data
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    //from AHM 
    public class WeightForm
    {
        [Key]
        public int Id { get; set; }

        public int AircraftId { get; set; }

        public virtual Aircraft Aircraft { get; set; }

        public double AircraftBasicWeight { get; set; }

        public double MaximumZeroFuelWeight { get; set; }

        public double MaximumLandingWeight { get; set; }

        public double MaximumTakeoffWeight { get; set; }


    }
}
