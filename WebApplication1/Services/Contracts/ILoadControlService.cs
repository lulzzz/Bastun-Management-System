namespace BMS.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface ILoadControlService
    {
        void CalculatePAXWeightByGender();

        void GetPassengersByZoneDistribution();

        string GetCorrectLoadingInstruction(string aircraftType);

    }
}
