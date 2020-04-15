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
    using BMS.Data.DTO;
    using BMS.Services.ParserUtility.UtilityContracts;

    public class MessageParser : IMessageParser
    {
        private readonly IMovementService movementService;
        private readonly IMessageService messageService;
        private readonly IFlightDataValidation flightDataValidation;
        private readonly IFlightService flightService;
        private readonly IContainerService containerService;
        private readonly IParserMovementUtility parserMovementUtility;
        private readonly Regex regex = new Regex("maika ti");
        private readonly Regex ldmFlightInfoRegex = new Regex(FlightInfoConstants.IsLDMFlightInfoValid);
        private readonly Regex loadDistributionRegex = new Regex(FlightInfoConstants.IsLDMLoadInfoValid);
        private readonly Regex loadSummaryRegex = new Regex(FlightInfoConstants.IsLDMLoadSummaryInfoValid);
        private const string movementDateFormat = "HH:MM:SS";
    
        //TODO: Refactor this
        public MessageParser(IMovementService movementService, IMessageService messageService, IFlightDataValidation flightDataValidation, 
            IFlightService flightService,
            IContainerService containerService,IParserMovementUtility parserMovementUtility)
        {
            this.movementService = movementService;
            this.messageService = messageService;
            this.flightDataValidation = flightDataValidation;
            this.flightService = flightService;
            this.containerService = containerService;
            this.parserMovementUtility = parserMovementUtility;
        }

        public bool ParseArrivalMovement(string messageContent)
        {
            string[] splitMessage =
                messageContent.Split("\r\n", StringSplitOptions.None);

            if (this.flightDataValidation.IsArrivalMovementFlightDataValid(splitMessage))
            {
                string[] flightData = this.parserMovementUtility.GetMovementFlightData(splitMessage[1]); 
                var inboundFlightByFlightNumber = this.flightService.GetInboundFlightByFlightNumber(flightData[0]);
                string[] arrivalMovementTimes = this.parserMovementUtility.GetTimes(splitMessage[2]); 
                DateTime[] validMovementTime = this.parserMovementUtility.(arrivalMovementTimes, inboundFlightByFlightNumber);
                    string supplementaryInformation = this.ParseSupplementaryInformation(splitMessage[3]);
                    this.movementService.CreateArrivalMovement(validMovementTime, supplementaryInformation, inboundFlightByFlightNumber);
                    return true; 
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

                if (inbound == null)
                {
                    return false;
                }
            } 
            else
            {
                return flag = false;
            }
            
            if (this.flightDataValidation.IsCPMFlightDataValid(splitMessageContent))
            {
                string supplementaryInformation = this.ParseSupplementaryInformation(splitMessageContent[splitMessageContent.Length - 1]);
                int amountOfInboundContainers = this.GetContainerCount(splitMessageContent);
                var listOfContainersForCurrentMessage = this.containerService.AddContainersToInboundFlight(inbound,amountOfInboundContainers);
               var listofContainerInfo =  this.containerService.CreateContainerInfo(splitMessageContent, listOfContainersForCurrentMessage);
                var dto = new CPMDTO(listofContainerInfo, supplementaryInformation);
                this.messageService.CreateInboundCPM(inbound, dto);
            } 
            else
            {
                flag = false;
            }
              

            return flag;
        }

        public bool ParseDepartureMovement(string messageContent)
        {
            
            string[] splitMessage = messageContent
                .Split("\r\n", StringSplitOptions.None);

            if (this.flightDataValidation.IsDepartureMovementFlightDataValid(splitMessage))
            {
                var match = regex.Match(splitMessage[1]);
                if (match.Success)
                {
                    string flightNumber = match.Groups["flt"].Value;
                    string registration = match.Groups["reg"].Value;
                    string date = match.Groups["date"].Value;
                    string station = match.Groups["origin"].Value;

                    var outboundFlightByFlightNumber = this.flightService.GetOutboundFlightByFlightNumber(flightNumber);
                    string supplementaryInformation = this.ParseSupplementaryInformation(splitMessage[splitMessage.Length - 1]);
                    int totalPax = this.ParseTotalPax(splitMessage[3]); 
                    string[] times = this.GetTimesForDepartureMovement(splitMessage[2]);
                    DateTime[] timesForDeparture = this.ParseTimesForDepartureMovement(times, outboundFlightByFlightNumber);
                    this.movementService.CreateDepartureMovement(timesForDeparture, supplementaryInformation, totalPax, outboundFlightByFlightNumber);
                    
                }
            }
            else
            {
                return false;
            }

            return true;
          
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
            } 
            else
            {
                result = "NIL";
            }

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

            var time1ParsedToDateTime = new DateTime(flightYear, flightMonth, flightDay, parsedTime1.Hours, parsedTime1.Minutes, parsedTime1.Seconds)
                .ToUniversalTime();
                
            var time2ParsedToDateTime = new DateTime(flightYear, flightMonth, flightDay, parsedTime2.Hours, parsedTime2.Minutes, parsedTime2.Seconds)
                .ToUniversalTime();


            return new DateTime[] { time1ParsedToDateTime, time2ParsedToDateTime };
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

       

        public bool ParseOutboundCPM(string messageContent)
        {
            bool flag = true;
            string[] splitMessageContent =
                messageContent
                .Split("\r\n", StringSplitOptions.None);

            OutboundFlight outbound;

            string flightNumberFromInput = this.GetFlightNumber(splitMessageContent[1]);

            if (flightNumberFromInput != null)
            {
                outbound = this.flightService.GetOutboundFlightByFlightNumber(flightNumberFromInput);

                if (outbound == null)
                {
                    return false;
                }
            }
            else
            {
                return flag = false;
            }

            if (this.flightDataValidation.IsCPMFlightDataValid(splitMessageContent))
            {
                string supplementaryInformation = this.ParseSupplementaryInformation(splitMessageContent[splitMessageContent.Length - 1]);
                int amountOfInboundContainers = this.GetContainerCount(splitMessageContent);
                var listOfContainersForCurrentMessage = this.containerService.AddContainersToOutboundFlight(outbound, amountOfInboundContainers);
                var listofContainerInfo = this.containerService.CreateContainerInfo(splitMessageContent, listOfContainersForCurrentMessage);
                var cpmDTO = new CPMDTO(listofContainerInfo, supplementaryInformation);
                this.messageService.CreateOutboundCPM(outbound, cpmDTO);
            }
            else
            {
                flag = false;
            }


            return flag;
        }


        public bool ParseInboundLDM(string messageContent)
        {
            string[] splitMessage =
                messageContent
                .Split("\r\n", StringSplitOptions.None);
         
            if (this.flightDataValidation.IsLDMFlightDataValid(splitMessage))
            {
                var ldmFlightInfoMatch = ldmFlightInfoRegex.Match(splitMessage[1]);
                if (ldmFlightInfoMatch.Success)
                {
                    string inboundFlightNumber = ldmFlightInfoMatch.Groups["flt"].Value;
                    string crewConfiguration = ldmFlightInfoMatch.Groups["crewConfig"].Value;
                    var loadMatch = loadDistributionRegex.Match(splitMessage[2]);
                    if (loadMatch.Success)
                    {
                        int[] paxFigures = this.ParsePAXFigures(splitMessage[2]);
                        int totalWeightInCompartments = this.ParseLDMTotalWeight(loadMatch.Groups["ttlWghtInCpt"].Value);
                        var weightInEachCompartment = this.ParseWeightsInCompartments(loadMatch.Groups["wghtByCompartment"].Value);
                        var loadSummaryMatch = loadSummaryRegex.Match(splitMessage[3]);
                        if (loadSummaryMatch.Success)
                        {
                            int[] loadSummaryInfo = this.ParseLoadSummaryInfo(splitMessage[3]);
                            var inboundFlight = this.flightService.GetInboundFlightByFlightNumber(inboundFlightNumber);
                            
                            if (inboundFlight != null)
                            {
                                var dto = new LDMDTO(crewConfiguration, paxFigures, totalWeightInCompartments, weightInEachCompartment, loadSummaryInfo);
                                this.messageService.CreateInboundLDM(inboundFlight, dto);
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
            else
            {
                return false;
            }

            return true;
        }

        public bool ParseOutboundLDM(string messageContent)
        {
            string[] splitMessage =
                   messageContent
                   .Split("\r\n", StringSplitOptions.None);

            if (this.flightDataValidation.IsLDMFlightDataValid(splitMessage))
            {
                var ldmFlightInfoMatch = ldmFlightInfoRegex.Match(splitMessage[1]);
                if (ldmFlightInfoMatch.Success)
                {
                    string outboundFlightNumber = ldmFlightInfoMatch.Groups["flt"].Value;
                    string crewConfiguration = ldmFlightInfoMatch.Groups["crewConfig"].Value;
                    var loadMatch = loadDistributionRegex.Match(splitMessage[2]);
                    if (loadMatch.Success)
                    {
                        int[] paxFigures = this.ParsePAXFigures(splitMessage[2]);
                        int totalWeightInCompartments = this.ParseLDMTotalWeight(loadMatch.Groups["ttlWghtInCpt"].Value);
                        var weightInEachCompartment = this.ParseWeightsInCompartments(loadMatch.Groups["wghtByCompartment"].Value);
                        var loadSummaryMatch = loadSummaryRegex.Match(splitMessage[3]);
                        if (loadSummaryMatch.Success)
                        {
                            int[] loadSummaryInfo = this.ParseLoadSummaryInfo(splitMessage[3]);
                            var outboundFlight = this.flightService.GetOutboundFlightByFlightNumber(outboundFlightNumber);

                            if (outboundFlight != null)
                            {
                                var dto = new LDMDTO(crewConfiguration, paxFigures, totalWeightInCompartments, weightInEachCompartment, loadSummaryInfo);
                                this.messageService.CreateOutboundLDM(outboundFlight, dto);
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
            else
            {
                return false;
            }

            return true;
        }


        private int ParseLDMTotalWeight(string totalWeightInCPT)
        {
            string[] splitData =
                totalWeightInCPT.Split(".", StringSplitOptions.RemoveEmptyEntries);

            int totalWeight = int.Parse(splitData[1]);

            return totalWeight;
        }

        private int ParseLDMTotalPax(string totalPax)
        {
            string[] splitData =
                totalPax
                .Split("/", StringSplitOptions.RemoveEmptyEntries);

            return int.Parse(splitData[1]);
        }

        private int ParseLDMTotalBags(string totalBags)
        {
            string[] splitData =
                totalBags.Split("/", StringSplitOptions.RemoveEmptyEntries);

            return int.Parse(splitData[1]);
        }

        private int ParseLDMCargo(string cargo)
        {
            string[] splitData =
                cargo.Split("/", StringSplitOptions.RemoveEmptyEntries);

            if (splitData[1] == "NIL")
            {
                return 0;
            }

            return int.Parse(splitData[1]);
        }

        private Dictionary<int,int> ParseWeightsInCompartments(string input)
        {
            var weightInCompartments = new Dictionary<int, int>();
            string[] splitByCompartments =
                input
                .Split(".", StringSplitOptions.RemoveEmptyEntries);

            foreach (var compartment in splitByCompartments)
            {
                string[] splitData =
                     compartment
                     .Split("/", StringSplitOptions.RemoveEmptyEntries);

                int compartmentNumber = int.Parse(splitData[0]);
                int weight = int.Parse(splitData[1]);
                weightInCompartments.Add(compartmentNumber, weight);
            }
            return weightInCompartments;
        }

        private int[] ParsePAXFigures(string input)
        {
            int inboundPaxMale = 0;
            int inboundPaxFemale = 0;
            int inboundPaxChildren = 0;
            int inboundPaxInfants = 0;
            var match = this.loadDistributionRegex.Match(input);
            
            if (match.Success)
            {
                inboundPaxMale = int.Parse(match.Groups["M"].Value);
                inboundPaxFemale = int.Parse(match.Groups["female"].Value);
                inboundPaxChildren = int.Parse(match.Groups["children"].Value);
                inboundPaxInfants = int.Parse(match.Groups["infants"].Value);

            }

            return new int[] { inboundPaxMale, inboundPaxFemale, inboundPaxChildren, inboundPaxInfants };
        }

        private int[] ParseLoadSummaryInfo(string input)
        {
            int totalPax = 0;
            int totalBags = 0;
            int totalCargo = 0;
            var match = loadSummaryRegex.Match(input);
            if (match.Success)
            {
                totalPax = this.ParseLDMTotalPax(match.Groups["PAX"].Value);
                totalBags = this.ParseLDMTotalBags(match.Groups["bags"].Value);
                totalCargo = this.ParseLDMCargo(match.Groups["cargo"].Value);
            }

            return new int[] { totalPax, totalBags, totalCargo };
        }
    }

    
}
