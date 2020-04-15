namespace BMS.Services.ParserUtility.ParserMovementUtility
{
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts.FlightContracts;
    using BMS.Services.ParserUtility.UtilityConstants;
    using BMS.Services.ParserUtility.UtilityContracts;
    using BMS.Services.Utility.UtilityConstants;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class ParserArrMVTUtility : IParserMovementUtility
    {
        private readonly Regex MovementFlightData = new Regex(FlightInfoConstants.IsFlightInfoValid);

        public string[] GetMovementFlightData(string flightData)
        {
            var flightDataMatch = MovementFlightData.Match(flightData);
            string flightNumber = flightDataMatch.Groups["flt"].Value;
            string registration = flightDataMatch.Groups["reg"].Value;
            string date = flightDataMatch.Groups["date"].Value;
            string station = flightDataMatch.Groups["origin"].Value;

            return new string[] { flightNumber, registration, date, station };
        }

        public string[] GetTimes(string timeData)
        {
            string firstTime = string.Empty;
            string secondTime = string.Empty;

            if (timeData != null)
            {
                string[] splitTimeData = timeData.Split("/", StringSplitOptions.RemoveEmptyEntries);
                firstTime = splitTimeData[0].Remove(0, 2);
                secondTime = splitTimeData[1];
            }

            return new string[] { firstTime, secondTime };
        }

        public string[] GetValidTimesFormat(string[] listOfTimes)
        {
            var firstTimeWithoutColon = listOfTimes[0].Insert(2, GlobalUtilityConstants.Colon);
            var firstTimeWithColonAfterMinutes = firstTimeWithoutColon.Insert(5, GlobalUtilityConstants.Colon);
            var firstTimeValid = firstTimeWithColonAfterMinutes.Insert(6, GlobalUtilityConstants.Zeroes);


            var secondTimeWithoutColon = listOfTimes[1].Insert(2, GlobalUtilityConstants.Colon);
            var secondTimeWithColonAfterMinutes = secondTimeWithoutColon.Insert(5, GlobalUtilityConstants.Colon);
            var secondTimeValid = secondTimeWithColonAfterMinutes.Insert(6, GlobalUtilityConstants.Zeroes);

            return new string[] { firstTimeValid, secondTimeValid };
        }

        public DateTime[] ParseMovementTimes(string[] times, IFlight inbound)
        {
            var arrOfValidTimes = this.GetValidTimesFormat(times);
            string touchdownTime = arrOfValidTimes[0];
            string onblockTime = arrOfValidTimes[1];

            if (touchdownTime == null || onblockTime == null)
            {
                return null;
            }

            var touchdownTimeToTimespan = TimeSpan.Parse(touchdownTime);
            var onblockTimeToTimespan = TimeSpan.Parse(onblockTime);


            var touchdownTimeParsed = new DateTime(inbound.STA.Year, inbound.STA.Month, inbound.STA.Day, touchdownTimeToTimespan.Hours, touchdownTimeToTimespan.Minutes, touchdownTimeToTimespan.Seconds)
                .ToUniversalTime(); ;
            var onblockTimeParsed = new DateTime(inbound.STA.Year, inbound.STA.Month, inbound.STA.Day, onblockTimeToTimespan.Hours, onblockTimeToTimespan.Minutes, onblockTimeToTimespan.Seconds)
                .ToUniversalTime();


            return new DateTime[] { touchdownTimeParsed, onblockTimeParsed };
        }
    }
}
