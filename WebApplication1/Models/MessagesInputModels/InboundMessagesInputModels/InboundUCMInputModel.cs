namespace BMS.Models.MessagesInputModels.InboundMessagesInputModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using BMS.GlobalData.ErrorMessages.InboundMessagesErrors;
    using BMS.GlobalData.Validation;

    public class InboundUCMMessageModel
    {
        [Required(ErrorMessage =InvalidUCMErrorMessages.UCMIsRequired)]
        [RegularExpression(MessagesValidation.UCMValidation,ErrorMessage =InvalidUCMErrorMessages.UCMFormatIsInvalid)]
        public string Message { get; set; }
    }
}
