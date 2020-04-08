namespace BMS.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class AircraftBaggageHold
    {
        public int BaggageHoldId { get; set; }

        [Required]
        public int AircraftId { get; set; }

        [Required]
        public virtual Aircraft Aircraft { get; set; }


        public int CompartmentOneCapacity { get; set; }

        public int CompartmentOneTotalWeight { get; set; }

        public int CompartmentTwoCapacity { get; set; }

        public int CompartmentTwoTotalWeight { get; set; }

        public int CompartmentThreeCapacity { get; set; }

        public int CompartmentThreeTotalWeight { get; set; }

        public int CompartmentFourCapacity { get; set; }

        public int CompartmentFourTotalWeight { get; set; }

        public int CompartmentFiveCapacity { get; set; }

        public int CompartmentFiveTotalWeight { get; set; }
    }
}
