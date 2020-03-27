namespace BMS.Models.MessagesInputModels.OutboundMessagesInputModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using BMS.GlobalData.ErrorMessages.InboundMessagesErrors;
    using BMS.CustomAttributes;
    using BMS.GlobalData.Validation;

    public class OutboundCPMInputModel
    {
        [Required(ErrorMessage =InvalidCPMErrorMessages.CPMIsRequired)]
        [MultipleRegex(MessagesValidation.CPMFlightInfoValidation,ErrorMessage = InvalidCPMErrorMessages.CPMFormatIsInvalid)]
        [MultipleRegex(MessagesValidation.CPMContainerInfoValidation, ErrorMessage =InvalidCPMErrorMessages.CPMContainerFormatIsInvalid)]
        [MultipleRegex(MessagesValidation.CPMSupplementaryInformationValidation, ErrorMessage =InvalidCPMErrorMessages.CPMSupplementaryInformationFormatIsInvalid)]
        public string Message { get; set; }
    }
}
