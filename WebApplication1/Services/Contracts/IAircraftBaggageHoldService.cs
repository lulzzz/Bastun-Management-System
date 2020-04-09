namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IAircraftBaggageHoldService
    {
        AircraftBaggageHold AddBaggageHoldToAircraft(Aircraft aircraft);

        void SetHoldData738(Aircraft aircraft);

        void SetHoldData752(Aircraft aircraft);

        void SetHoldData763(Aircraft aircraft);

        void SetHoldData788(Aircraft aircraft);

        void SetHoldData789(Aircraft aircraft);
    }
}
