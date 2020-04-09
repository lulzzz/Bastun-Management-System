namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IAircraftCabinService
    {
        void AddCabinToAircraft(Aircraft aircraft);

    }
}
