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

    public class MessageParser : IMessageParser
    {
        private readonly IMovementService movementService;
        private readonly IMessageService messageService;
        private readonly IAircraftService aircraftService;
        private readonly IFlightService flightService;


        public MessageParser(IMovementService movementService, IMessageService messageService, IAircraftService aircraftService, IFlightService flightService)
        {
            this.movementService = movementService;
            this.messageService = messageService;
            this.aircraftService = aircraftService;
            this.flightService = flightService;
        }

        public void ParseArrivalMovement(string messageContent)
        {
            string[] splitMessage =
                messageContent.Split("\r\n", StringSplitOptions.None);

            if (MessageTypeValidation.IsArrivalMovementMessageTypeValid(splitMessage[0]))
            {
                var flightRegex = new Regex(FlightInfoConstants.IsFlightInfoValid);
                var flightMatch = flightRegex.Match(splitMessage[1]);

                if (flightMatch.Success)
                {

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
