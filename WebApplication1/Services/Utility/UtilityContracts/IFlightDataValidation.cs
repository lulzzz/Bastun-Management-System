namespace BMS.Services.Utility.UtilityContracts
{
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IFlightDataValidation
    {

        bool IsCPMFlightDataValid(string[] splitMessageContent);

        bool IsArrivalMovementFlightDataValid(string[] splitMessageContent);

    }
}
