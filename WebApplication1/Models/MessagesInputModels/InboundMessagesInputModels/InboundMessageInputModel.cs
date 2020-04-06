namespace BMS.Models.MessagesInputModels.InboundMessagesInputModels
{
    using BMS.GlobalData.ErrorMessages.InboundMessagesErrors;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class InboundMessageInputModel
    {
        [Required(ErrorMessage = InvalidLDMErrorMessages.LDMIsRequired)]
        public string LDMMessage { get; set; }

        [Required(ErrorMessage = InvalidCPMErrorMessages.CPMIsRequired)]
        public string CPMMessage { get; set; }

        [Required(ErrorMessage = InvalidUCMErrorMessages.UCMIsRequired)]
        public string UCMMessage { get; set; }
    }
}
