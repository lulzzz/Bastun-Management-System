namespace BMS.Data.DTO.FuelAndWeightDTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class WeightFormDTO
    {
        public int AircraftBasicWeight { get; set; }

        public int MaximumZeroFuelWeight { get; set; }

        public int MaximumLandingWeight { get; set; }

        public int MaximumTakeoffWeight { get; set; }

    }
}
