namespace BMS.Services
{
    using BMS.Data.Models;
    using BMS.Data.Models.Messages;
    using BMS.GlobalData.Validation;
    using BMS.Models.MovementsInputModels;
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using BMS.Services.ParserUtility;
    using System.Threading.Tasks;
    using BMS.Services.Utility.UtilityConstants;
    using BMS.Services.Utility;
    using BMS.Services.Utility.UtilityContracts;
    using System.Globalization;

    public class MessageParser : IMessageParser
    {
        private readonly IMovementService movementService;
        private readonly IMessageService messageService;
        private readonly IFlightDataValidation flightDataValidation;
        private readonly IFlightService flightService;
        private const string movementDateFormat = "HH:MM:SS";
        private const string _colon = ":";
        private const string _zeros = "00";

        public MessageParser(IMovementService movementService, IMessageService messageService, IFlightDataValidation flightDataValidation, IFlightService flightService)
        {
            this.movementService = movementService;
            this.messageService = messageService;
            this.flightDataValidation = flightDataValidation;
            this.flightService = flightService;
        }

        public bool ParseArrivalMovement(string messageContent)
        {
            bool flag = true;
            string[] splitMessage =
                messageContent.Split("\r\n", StringSplitOptions.None);

            if (MessageValidation.IsArrivalMovementMessageTypeValid(splitMessage[0]))
            {
                var flightRegex = new Regex(FlightInfoConstants.IsFlightInfoValid);
                var flightMatch = flightRegex.Match(splitMessage[1]);

                if (flightMatch.Success)
                {
                    string fltNmb = flightMatch.Groups["flt"].Value;
                    string date = flightMatch.Groups["date"].Value;
                    string registration = flightMatch.Groups["registration"].Value;
                    string station = flightMatch.Groups["station"].Value;

                    if (!MessageValidation.IsFlightInfoNotNullOrEmpty(fltNmb,registration,date,station))
                    {
                        if (this.flightDataValidation.IsFlightNumberAndRegistrationValid(fltNmb,registration))
                        {
                            if (this.flightDataValidation.IsDateAndStationValid(fltNmb,date,station))
                            {
                                string supplementaryInformation = this.ParseSupplementaryInformation(splitMessage[3]);
                                var flightByFlightNumber = this.flightService
                                    .GetFlightByFlightNumber(this.flightDataValidation.GetCorrectFlightNumber(fltNmb));
                                string[] times = this.ParseTimeForMovements(splitMessage[2]);
                                DateTime[] dates = this.ParseTimesForArrivalMovement(times, flightByFlightNumber);

                            } 
                            else
                            {
                                flag = false;
                            }
                        } 
                        else
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            else
            {
                flag = false;
            }

            return flag; 
        }

        public void ParseCPM(string messageContent)
        {



        }

        public void ParseDepartureMovement(string messageContent)
        {

        }

        public void ParseLDM(string messageContent)
        {

        }

        public void ParseUCM(string messageContent)
        {

        }

        private string ParseSupplementaryInformation(string supplementaryInfo)
        {
            string result = string.Empty;

            if (!supplementaryInfo.Contains("NIL"))
            {
                string[] splitData = supplementaryInfo
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string actualData = splitData[1];
                result = actualData;
            } else
            {
                result = "NIL";
            }

            return result;
        }

        private string[] ParseTimeForMovements(string timeData)
        {
            string touchdownTime = string.Empty;
            string onblockTime = string.Empty;
            if (timeData != null)
            {
                string[] splitTimeData = timeData.Split("/",StringSplitOptions.RemoveEmptyEntries);
                touchdownTime = splitTimeData[0].Remove(0, 2);
                onblockTime = splitTimeData[1];

            }
            string[] result = new string[]
            {
                touchdownTime,
                onblockTime
            };
            return result;
        }

        private TimeSpan[] ParseTimesForArrivalMovement(string[] times, Flight flight)
        {
            var arrOfValidTimes = this.GetValidTimesFormat(times);
            string touchdownTime = arrOfValidTimes[0];
            string onblockTime = arrOfValidTimes[1];

            if (touchdownTime == null || onblockTime == null)
            {
                return null;
            }

            var parsedTouchdownTime = TimeSpan.Parse(touchdownTime);
            var parsedOnBlockTime = TimeSpan.Parse(onblockTime);

            var flightDate = flight.STA;
            var touchdownTimeAsDateTime = new DateTime(flightDate.Year, flightDate.Month, flightDate.Day, parsedTouchdownTime.Hours, parsedTouchdownTime.Minutes, parsedTouchdownTime.Seconds);
            var onblockTimeAsDateTime = new DateTime(flightDate.Year, flightDate.Month, flightDate.Day, parsedTouchdownTime.Hours, parsedTouchdownTime.Minutes, parsedTouchdownTime.Seconds);

            return new DateTime[] { touchdownTimeAsDateTime, onblockTimeAsDateTime };
        }

        private string[] GetValidTimesFormat(string[] listOfTimes)
        {
            var touchdownTimeWithColon = listOfTimes[0].Insert(2, _colon);
            var newTouchdownWithColonAfterMinutes = touchdownTimeWithColon.Insert(5, _colon);
            var touchdownTime = newTouchdownWithColonAfterMinutes.Insert(6, _zeros);


            var onblockTimeWithColon = listOfTimes[1].Insert(2, _colon);
            var newOnBlockTimeWithColonAfterMinutes = onblockTimeWithColon.Insert(5, _colon);
            var onblockTime = newOnBlockTimeWithColonAfterMinutes.Insert(6, _zeros);

            return new string[] { touchdownTime, onblockTime };
        }


    }
}
