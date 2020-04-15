namespace BMS.Services.ParserUtility.UtilityContracts
{
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts.FlightContracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IParserMovementUtility
    {
        string[] GetMovementFlightData(string flightData);

        string[] GetTimes(string timeData);

        string[] GetValidTimesFormat(string[] listOfTimes);

    }
}
