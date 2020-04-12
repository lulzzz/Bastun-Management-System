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

        public int TotalWeightInAllCompartments { get; set; }

        public int TTLWeightInCPT1 { get; set; }

        public int TTLWeightInCPT2 { get; set; }

        public int TTlWeightINCPT3 { get; set; }

        public int TTLWeightInCPT4 { get; set; }

        public int TTLWeightInCPT5 { get; set; }

        public int TotalPax { get; set; }

        public int TotalBaggagePieces { get; set; }

        public int TotalCargo { get; set; }


    }
}
