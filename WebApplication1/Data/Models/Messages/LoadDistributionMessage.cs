namespace BMS.Data.Models.Messages
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class LoadDistributionMessage : Message
    {
        public string CrewConfiguration { get; set; }

        public int PAXMale { get; set; }

        public int PAXFemale { get; set; }

        public int PAXChildren { get; set; }

        public int PAXInfants { get; set; }

        public int TotalWeightInCompartments { get; set; }

        [Required]
        public int AircraftBaggageHoldId { get; set; }

        [Required]
        public AircraftBaggageHold WeightByCompartment { get; set; }

        [Range(0,189, ErrorMessage = "Invalid pax number!")]
        public int TotalPax { get; set; }

        public int TotalBaggagePieces { get; set; }

        public int TotalCargo { get; set; }


    }
}
