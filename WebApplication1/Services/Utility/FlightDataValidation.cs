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
            bool flag = true;
            if (this.flightService.CheckFlightNumber(flightNumber))
            {
                if (!this.aircraftService.CheckAircraftRegistration(registration))
                {
                   
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }

        private bool IsDateAndStationValid(string flightNumber,string date, string station)
        {
            bool flag = true;

            var flightfromdb = this.flightService.GetInboundFlightByFlightNumber(flightNumber);

            if (flightfromdb.Origin != station || flightfromdb.STA.Day.ToString() != date)
            {
                flag = false;
            }

           
            return flag;
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
        
    }
}
