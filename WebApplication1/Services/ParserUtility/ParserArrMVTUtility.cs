namespace BMS.Services.ParserUtility
{
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts.FlightContracts;
    using BMS.Services.ParserUtility.UtilityContracts;
    using BMS.Services.Utility.UtilityConstants;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class ParserArrMVTUtility : IParserMovementUtility
    {
        private readonly Regex movementFlightDataRegex = new Regex(FlightInfoConstants.IsFlightInfoValid);

        public string[] GetMovementFlightData(string flightData)
        {
            var flightDataMatch = movementFlightDataRegex.Match(flightData);
            string flightNumber = flightDataMatch.Groups["flt"].Value;
            string registration = flightDataMatch.Groups["reg"].Value;
            string date = flightDataMatch.Groups["date"].Value;
            string station = flightDataMatch.Groups["origin"].Value;

            return new string[] { flightNumber, registration, date, station };
        }

        public string[] GetTimes(string timeData)
        {
            string touchdownTime = string.Empty;
            string onblockTime = string.Empty;

            if (timeData != null)
            {
                string[] splitTimeData = timeData.Split("/", StringSplitOptions.RemoveEmptyEntries);
                touchdownTime = splitTimeData[0].Remove(0, 2);
                onblockTime = splitTimeData[1];
            }

            return new string[] { touchdownTime, onblockTime };
        }

        public string[] GetValidTimesFormat(string[] listOfTimes)
        {
            throw new NotImplementedException();
        }

        public DateTime[] ParseArrivalMovementTimes(string[] times, IInbound inbound)
        {
            throw new NotImplementedException();
        }
    }
}
