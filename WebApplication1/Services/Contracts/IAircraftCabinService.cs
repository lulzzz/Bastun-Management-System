namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IAircraftCabinService
    {
        AircraftCabin AddCabinToAircraft(Aircraft aircraft);

        void SetCabinData738(AircraftCabin cabin);

        void SetCabinData752(AircraftCabin cabin);

        void SetCabinData763(AircraftCabin cabin);

        void SetCabinData788(AircraftCabin cabin);

        void SetCabinData789(AircraftCabin cabin);

        void SetCabinData320(AircraftCabin cabin);

       
    }
}
