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

    public class MessageParser : IMessageParser
    {
        private readonly IMovementService movementService;
        private readonly IMessageService messageService;
        private readonly IFlightDataValidation flightDataValidation;

        public MessageParser(IMovementService movementService, IMessageService messageService, IFlightDataValidation flightDataValidation)
        {
            this.movementService = movementService;
            this.messageService = messageService;
            this.flightDataValidation = flightDataValidation;
        }

        public void ParseArrivalMovement(string messageContent)
        {
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
                            
                        } 
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                //do something
            }
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


    }
}
