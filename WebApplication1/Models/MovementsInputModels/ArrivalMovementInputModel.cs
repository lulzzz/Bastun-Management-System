using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BMS.GlobalData.ErrorMessages;
using BMS.GlobalData.Validation;

namespace BMS.Models.MovementsInputModels
{
    public class ArrivalMovementInputModel
    {
        [Required(ErrorMessage =InvalidArrivalMovementErrorMessages.ArrivalMovementIsRequired)]
        [RegularExpression(MessagesValidation.ArrMVTMessageValidation,ErrorMessage =InvalidArrivalMovementErrorMessages.ArrivalMovementIsInvalid)]
        public string Message { get; set; }
    }
}
