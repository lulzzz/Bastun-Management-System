namespace BMS.Services.ParserUtility.UtilityContracts
{
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts.FlightContracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public interface IParserMovementUtility
    {
        Regex MovementFlightData { get; set; }

        string[] GetMovementFlightData(string flightData);

        string[] GetTimes(string timeData);

        string[] GetValidTimesFormat(string[] listOfTimes);

        DateTime[] ParseMovementTimes(string[] flightData, IFlight flight);

    }
}
