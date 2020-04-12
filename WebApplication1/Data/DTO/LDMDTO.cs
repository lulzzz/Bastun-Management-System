namespace BMS.Data.DTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class LDMDTO
    {
        public LDMDTO(string config, int male, int female, int children, int infants, int ttlWeight,Dictionary<int,int> cptWeights,int totalPax, int ttlBags, int cargo)
        {
            this.CrewConfiguration = config;
            this.PAXMale = male;
            this.PAXFemale = female;
            this.PAXChildren = children;
            this.PAXInfants = infants;
            this.TotalWeightInAllCompartments = ttlWeight;
            this.TotalPax = totalPax;
            this.TotalBaggagePieces = ttlBags;
            this.TotalCargo = cargo;
            this.SetCompartmentWeights(cptWeights);
        }

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

        private void SetCompartmentWeights(Dictionary<int,int> cptWeights)
        {
           
        }
    }
}
