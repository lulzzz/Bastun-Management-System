namespace BMS.Data.Models.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class LoadDistributionMessage
    {
        public int Id { get; set; }

        public int FlightRef { get; set; }
        public Flight Flight { get; set; }

        public string CrewConfiguration { get; set; }

        public int PAXMale { get; set; }

        public int PAXFemale { get; set; }

        public int PAXChildren { get; set; }

        public int PAXInfant { get; set; }

        public int TotalPayloadWeight { get; set; }

        public string PayloadPerCompartments { get; set; }

        public int TotalPAX { get; set; }

        public int TotalBags { get; set; }

        public int CargoWeight { get; set; }
    }
}
