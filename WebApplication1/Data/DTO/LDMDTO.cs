namespace BMS.Data.DTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class LDMDTO
    {
        public LDMDTO(string config, int[] paxFigures,int totalWeightInCpts,Dictionary<int,int> compartmentWeights, int[] summaryInfo)
        {
            this.CrewConfiguration = config;
            this.TotalWeightInAllCompartments = totalWeightInCpts;
            this.SetCompartmentWeights(compartmentWeights);
            this.SetSummaryInfo(summaryInfo);
            this.SetPaxFigures(paxFigures);
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
            this.TTLWeightInCPT1 = cptWeights[1];
            this.TTLWeightInCPT2 = cptWeights[2];
            this.TTlWeightINCPT3 = cptWeights[3];
            this.TTLWeightInCPT4 = cptWeights[4];
            this.TTLWeightInCPT5 = cptWeights[5];
        }

        private void SetSummaryInfo(int[] summaryInfo)
        {
            this.TotalPax = summaryInfo[0];
            this.TotalBaggagePieces = summaryInfo[1];
            this.TotalCargo = summaryInfo[2];
        }

        private void SetPaxFigures(int[] paxFigures)
        {
            this.PAXMale = paxFigures[0];
            this.PAXFemale = paxFigures[1];
            this.PAXChildren = paxFigures[2];
            this.PAXInfants = paxFigures[3];
        }
    }
}
