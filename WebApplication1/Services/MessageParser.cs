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
    using System.Threading.Tasks;
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

        public void ParseArrivalMovement(ArrivalMovementInputModel arrMvtInputModel)
        {
            var regeOptions = RegexOptions.Compiled | RegexOptions.IgnoreCase;
            var arrivalMovementRegex  = new Regex(MessagesValidation.ArrMVTMessageValidation,regeOptions);
            var arrMVTMatch = arrivalMovementRegex.Matches(arrMvtInputModel.Message);
            
            
        }

        public void ParseCPM(string messageContent)
        {
            var cpmFlightInfoRegex = new Regex(MessagesValidation.CPMFlightInfoValidation);
            var cpmContainerInfoRegex = new Regex(MessagesValidation.CPMContainerInfoValidation);
            var cpmSupplementaryInformationRegex = new Regex(MessagesValidation.CPMSupplementaryInformationValidation);


        }

        public void ParseDepartureMovement(DepartureMovementInputModel depMVTInputModel)
        {
            var departureMovementRegex = new Regex(MessagesValidation.DepMVTMessageValidation);
        }

        public void ParseLDM(string messageContent)
        {
            var loadDistributionMessageRegex = new Regex(MessagesValidation.LDMMessageValidation);
        }

        public void ParseUCM(string messageContent)
        {
            var ucmRegex = new Regex(MessagesValidation.UCMValidation);
        }
    }
}
