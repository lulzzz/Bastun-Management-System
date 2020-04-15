namespace BMS.Services.ParserUtility.ParserMovementUtility
{
    using BMS.Data.Models.Contracts.FlightContracts;
    using BMS.Services.ParserUtility.UtilityConstants;
    using BMS.Services.ParserUtility.UtilityContracts;
    using BMS.Services.Utility.UtilityConstants;
    using System;
    using System.Collections.Generic;
   
    using System.Text.RegularExpressions;
   

    public class ParserDepMVTUtility : IParserMovementUtility
    {
        public Regex MovementFlightData { get; set; } = new Regex(FlightInfoConstants.IsFlightInfoValid);

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
            string[] splitTimeData =
                timeData
                .Split("ETA", StringSplitOptions.RemoveEmptyEntries);

            string[] tokens = splitTimeData[0]
                .Split("/", StringSplitOptions.RemoveEmptyEntries);

            string offBlockTime = tokens[0].Remove(0, 2);
            string takeoffTime = tokens[1];

            return new string[] { offBlockTime, takeoffTime };
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

        public DateTime[] ParseMovementTimes(string[] flightData, IFlight outbound)
        {
            var arrOfValidTimes = this.GetValidTimesFormat(flightData);
            string time1 = arrOfValidTimes[0];
            string time2 = arrOfValidTimes[1];

            if (time1 == null || time2 == null)
            {
                return null;
            }

            var parsedTime1 = TimeSpan.Parse(time1);
            var parsedTime2 = TimeSpan.Parse(time2);


            var time1ParsedToDateTime = new DateTime(outbound.STD.Year, outbound.STD.Month, outbound.STD.Day, parsedTime1.Hours, parsedTime1.Minutes, parsedTime1.Seconds)
                .ToUniversalTime();

            var time2ParsedToDateTime = new DateTime(outbound.STD.Year, outbound.STD.Month, outbound.STD.Day, parsedTime2.Hours, parsedTime2.Minutes, parsedTime2.Seconds)
                .ToUniversalTime();


            return new DateTime[] { time1ParsedToDateTime, time2ParsedToDateTime };
        }
    }
}
