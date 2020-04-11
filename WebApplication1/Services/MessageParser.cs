namespace BMS.Services
{
    using BMS.Data.Models;
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
        private readonly IContainerService containerService;
        private readonly Regex regex = new Regex(FlightInfoConstants.IsFlightInfoValid);
        private const string movementDateFormat = "HH:MM:SS";
        private const string _colon = ":";
        private const string _zeros = "00";
        //TODO: Refactor this
        public MessageParser(IMovementService movementService, IMessageService messageService, IFlightDataValidation flightDataValidation, IFlightService flightService, IContainerService containerService)
        {
            this.movementService = movementService;
            this.messageService = messageService;
            this.flightDataValidation = flightDataValidation;
            this.flightService = flightService;
            this.containerService = containerService;
        }

        public bool ParseArrivalMovement(string messageContent)
        {
            
            string[] splitMessage =
                messageContent.Split("\r\n", StringSplitOptions.None);

            if (this.flightDataValidation.IsArrivalMovementFlightDataValid(splitMessage))
            {
                var match = regex.Match(splitMessage[1]);
                if (match.Success)
                {
                    string flightNumber = match.Groups["flt"].Value;
                    string registration = match.Groups["reg"].Value;
                    string date = match.Groups["date"].Value;
                    string station = match.Groups["origin"].Value;

                    var inboundFlightByFlightNumber = this.flightService.GetInboundFlightByFlightNumber(flightNumber);
                    string[] arrivalMovementTimes = this.GetTimesForArrivalMovement(date);
                    DateTime[] validMovementTime = this.ParseTimesForArrivalMovement(arrivalMovementTimes, inboundFlightByFlightNumber);
                    string supplementaryInformation = this.ParseSupplementaryInformation(splitMessage[3]);
                    this.movementService.CreateArrivalMovement(validMovementTime, supplementaryInformation, inboundFlightByFlightNumber);

                    return true;
                }
                else
                {
                    return false;
                }
            } 
            else
            {
                return false;
            }
           
        }

        public bool ParseInboundCPM(string messageContent)
        {
            //method returns true if message has been created successfully 
            //else returns false
            bool flag = true;
            string[] splitMessageContent =
                messageContent
                .Split("\r\n", StringSplitOptions.None);

            InboundFlight inbound;

            string flightNumberFromInput = this.GetFlightNumber(splitMessageContent[1]);

            if (flightNumberFromInput != null)
            {
                inbound = this.flightService.GetInboundFlightByFlightNumber(flightNumberFromInput);
            } 
            else
            {
                return flag = false;
            }
            
            if (this.flightDataValidation.IsCPMFlightDataValid(splitMessageContent))
            {
                string supplementaryInformation = this.ParseSupplementaryInformation(splitMessageContent[splitMessageContent.Length - 1]);
                int amountOfInboundContainers = this.GetContainerCount(splitMessageContent);
                var listOfContainersForCurrentMessage = this.containerService.AddContainerToInboundFlight(inbound,amountOfInboundContainers);
               var listofContainerInfo =  this.containerService.CreateContainerInfo(splitMessageContent, listOfContainersForCurrentMessage);
                this.messageService.CreateInboundCPM(listofContainerInfo, inbound, supplementaryInformation);
            } 
            else
            {
                flag = false;
            }
              

            return flag;
        }

        public void ParseDepartureMovement(string messageContent)
        {
            bool flag = true;
            string[] splitMessage = messageContent
                .Split("\r\n", StringSplitOptions.None);


          
        }

        public bool ParseLDM(string messageContent)
        {

            bool flag = true;
            string[] splitMessage =
               messageContent.Split("\r\n", StringSplitOptions.None);

            string messageType = splitMessage[0];

            if (MessageValidation.IsLoadDistributionMessageTypeValid(messageType))
            {
                
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public void ParseUCM(string messageContent)
        {

        }

        private string ParseSupplementaryInformation(string supplementaryInfo)
        {
            string result = string.Empty;

            if (!supplementaryInfo.Contains("NIL"))
            {
                //TODO: Test for arrival movement
                string[] splitData = supplementaryInfo
                    .Split("SI", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string actualData = splitData[0];
                result = actualData;
            } else
            {
                result = "NIL";
            }

            return result;
        }

        private string[] GetTimesForArrivalMovement(string timeData)
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

        private string[] GetTimesForDepartureMovement(string timeData)
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

        private DateTime[] ParseTimesForArrivalMovement(string[] times, InboundFlight inboundFlight)
        {
            var arrOfValidTimes = this.GetValidTimesFormat(times);
            string time1 = arrOfValidTimes[0];
            string time2 = arrOfValidTimes[1];

            if (time1 == null || time2 == null)
            {
                return null;
            }

            var parsedTime1 = TimeSpan.Parse(time1);
            var parsedTime2 = TimeSpan.Parse(time2);

            int flightYear = inboundFlight.STA.Year;
            int flightMonth = inboundFlight.STA.Month;
            int flightDay = inboundFlight.STA.Day;

            var time1ParsedToDateTime = new DateTime(flightYear, flightMonth, flightDay, parsedTime1.Hours, parsedTime1.Minutes, parsedTime1.Seconds)
                .ToUniversalTime(); ;
            var time2ParsedToDateTime = new DateTime(flightYear, flightMonth, flightDay, parsedTime2.Hours, parsedTime2.Minutes, parsedTime2.Seconds)
                .ToUniversalTime();

            
            return new DateTime[] { time1ParsedToDateTime, time2ParsedToDateTime };
        }

        private DateTime[] ParseTimesForDepartureMovement(string[] times, OutboundFlight outboundFlight)
        {
            var arrOfValidTimes = this.GetValidTimesFormat(times);
            string time1 = arrOfValidTimes[0];
            string time2 = arrOfValidTimes[1];

            if (time1 == null || time2 == null)
            {
                return null;
            }

            var parsedTime1 = TimeSpan.Parse(time1);
            var parsedTime2 = TimeSpan.Parse(time2);

            int flightYear = outboundFlight.STD.Year;
            int flightMonth = outboundFlight.STD.Month;
            int flightDay = outboundFlight.STD.Day;

            var time1ParsedToDateTime = new DateTime(flightYear, flightMonth, flightDay, parsedTime1.Hours, parsedTime1.Minutes, parsedTime1.Seconds);
                
            var time2ParsedToDateTime = new DateTime(flightYear, flightMonth, flightDay, parsedTime2.Hours, parsedTime2.Minutes, parsedTime2.Seconds);

            var offBlockTimeInUTC = time1ParsedToDateTime.ToUniversalTime();
            var takeoffTimeInUTC =  time2ParsedToDateTime.ToUniversalTime();

            return new DateTime[] { time1ParsedToDateTime, time2ParsedToDateTime };
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

        private int ParseTotalPax(string totalPax)
        {
            return int.Parse(totalPax.Remove(0, 3));
        }


        private int GetContainerCount(string[] splitCpmData)
        {
            int containerCount = 0;

            for (int i = 2; i < splitCpmData.Length - 1; i++)
            {
                containerCount++;
            }

            return containerCount;
        }

        private string GetFlightNumber(string message)
        {
            if (message != null)
            {
                var match = regex.Match(message);

                if (match.Success)
                {
                    return match.Groups["flt"].Value;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

    }
}
