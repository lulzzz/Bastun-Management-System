namespace BMS.Data.DTO.FuelAndWeightDTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class FuelFormDTO
    {
        public string CrewConfiguration { get; set; }

        public DateTime Date { get; set; }

        public string PilotInCommand { get; set; }

        public int DryOperatingWeight { get; set; }

        public double DryOperatingIndex { get; set; }

        public int TaxiFuel { get; set; }

        public int BlockFuel { get; set; }

        public int TakeoffFuel { get; set; }


    }
}
