namespace BMS.Models.MessagesInputModels.InboundMessagesInputModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using BMS.GlobalData.Validation;
    using BMS.GlobalData.ErrorMessages.InboundMessagesErrors;

    public class InboundLDMInputModel
    {
        [Required(ErrorMessage = InvalidLDMErrorMessages.LDMIsRequired)]
        [RegularExpression(MessagesValidation.LDMMessageValidation, ErrorMessage = InvalidLDMErrorMessages.LDMFormatIsInvalid)]
        public string Message { get; set; }
    }
}
