namespace BMS.Services.Utility
{
    using BMS.Services.ParserUtility;
    using BMS.Services.Contracts;
    using BMS.Services.Utility.UtilityContracts;
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BMS.Services.Utility.UtilityConstants;

    public class FlightDataValidation : IFlightDataValidation
    {
        private readonly IFlightService flightService;
        private readonly IAircraftService aircraftService;
        private const string _hyphen = "-";


        public FlightDataValidation(IFlightService flightService, IAircraftService aircraftService)
        {
            this.flightService = flightService;
            this.aircraftService = aircraftService;
        }

       
   
        private bool IsFlightNumberAndRegistrationValid(string flightNumber, string registration)
        {
            bool isFlightInbound = this.flightService.CheckIfFlightIsInbound(flightNumber);
            bool isFlightOutbound = this.flightService.CheckIfFlightIsOutbound(flightNumber);

            if (isFlightInbound)
            {
                if (this.aircraftService.CheckAircraftRegistration(registration))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                 
            } 
            else if(isFlightOutbound)
            {
                if (this.aircraftService.CheckAircraftRegistration(registration))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        private bool IsDateAndStationValid(string flightNumber,string date, string station)
        {
            bool isFlightInbound = this.flightService.CheckIfFlightIsInbound(flightNumber);
            bool isFlightOutbound = this.flightService.CheckIfFlightIsOutbound(flightNumber);

            if (isFlightInbound)
            {
                var inboundFlightByFlightNumber = this.flightService.GetInboundFlightByFlightNumber(flightNumber);

                if (inboundFlightByFlightNumber != null)
                {
                    if (inboundFlightByFlightNumber.STA.Day.ToString() != date || inboundFlightByFlightNumber.Origin != station)
                    {
                        return false;
                    } 
                    else
                    {
                        return true;
                    }
                }
            } 
            else if(isFlightInbound)
            {
                var outboundFlightByFlightNumber = this.flightService.GetOutboundFlightByFlightNumber(flightNumber);
                if (outboundFlightByFlightNumber != null)
                {
                    if (outboundFlightByFlightNumber.STD.Day.ToString() != date || outboundFlightByFlightNumber.Destination != station)
                    {
                        return false;
                    } 
                    else
                    {
                        return true;
                    }
                }
            }

            return true;
        }

        public bool IsCPMFlightDataValid(string[] splitMessageContent)
        {
            bool flag = true;

            if (MessageValidation.IsCPMMessageTypeValid(splitMessageContent[0]))
            {
                var flightRegex = new Regex(FlightInfoConstants.IsFlightInfoValid);
                var match = flightRegex.Match(splitMessageContent[1]);

                if (match.Success)
                {
                    string flightNumber = match.Groups["flt"].Value;
                    string date = match.Groups["date"].Value;
                    string registration = match.Groups["reg"].Value;
                    string station = match.Groups["origin"].Value;

                    if (this.IsFlightNumberAndRegistrationValid(flightNumber, registration))
                    {
                        if (this.IsDateAndStationValid(flightNumber,date,station))
                        {
                            return flag;
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
                
            } else
            {
                flag = false;
            }

            return flag;
        }

        public bool IsArrivalMovementFlightDataValid(string[] splitMessageContent)
        {
            if (MessageValidation.IsMovementMessageTypeValid(splitMessageContent[0]))
            {
                var regex = new Regex(FlightInfoConstants.IsFlightInfoValid);

                var match = regex.Match(splitMessageContent[1]);
                if (match.Success)
                {
                    string flightNumber = match.Groups["flt"].Value;
                    string registration = match.Groups["reg"].Value;
                    string date = match.Groups["date"].Value;
                    string station = match.Groups["origin"].Value;

                    var test = MessageValidation.IsFlightInfoNotNullOrEmpty(flightNumber, registration, date, station);
                    if (MessageValidation.IsFlightInfoNotNullOrEmpty(flightNumber, registration,date, station))
                    {
                        if (this.IsFlightNumberAndRegistrationValid(flightNumber, registration))
                        {
                            if (this.IsDateAndStationValid(flightNumber, date, station))
                            {
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

        public bool IsUCMFlightDataValid(string[] splitMessageContent)
        {
            throw new NotImplementedException();
        }

        public bool IsLDMFlightDataValid(string[] splitMessageContent)
        {
            if (MessageValidation.IsLoadDistributionMessageTypeValid(splitMessageContent[0]))
            {
                 
            } 
            else
            {
                return false;
            }

            return true;
        }

        public bool IsDepartureMovementFlightDataValid(string[] splitMessageContent)
        {
            string messageType = splitMessageContent[0];

            if (MessageValidation.IsMovementMessageTypeValid(messageType))
            {
                var flightRegex = new Regex(FlightInfoConstants.IsFlightInfoValid);
                var match = flightRegex.Match(splitMessageContent[1]);

                if (match.Success)
                {
                    string flightNumber = match.Groups["flt"].Value;
                    string registration = match.Groups["reg"].Value;
                    string date = match.Groups["date"].Value;
                    string station = match.Groups["origin"].Value;

                    if (MessageValidation.IsFlightInfoNotNullOrEmpty(flightNumber, registration, date, station))
                    {
                        if (this.IsFlightNumberAndRegistrationValid(flightNumber, registration))
                        {
                            if (this.IsDateAndStationValid(flightNumber, date, station))
                            {
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
    }
}
