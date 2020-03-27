namespace BMS.Models.MessagesInputModels.InboundMessagesInputModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using BMS.CustomAttributes;
    using BMS.GlobalData.Validation;
    using BMS.GlobalData.ErrorMessages.InboundMessagesErrors;

    public class InboundCPMInputModel
    {
        [Required(ErrorMessage =InvalidCPMErrorMessages.CPMIsRequired)]
        [MultipleRegex(MessagesValidation.CPMFlightInfoValidation,ErrorMessage = InvalidCPMErrorMessages.CPMFormatIsInvalid)]
        [MultipleRegex(MessagesValidation.CPMContainerInfoValidation, ErrorMessage = InvalidCPMErrorMessages.CPMContainerFormatIsInvalid)]
        [MultipleRegex(MessagesValidation.CPMSupplementaryInformationValidation, ErrorMessage =InvalidCPMErrorMessages.CPMSupplementaryInformationFormatIsInvalid)]
        public string Message { get; set; }
    }
}
