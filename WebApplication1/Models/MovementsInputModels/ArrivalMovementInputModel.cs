using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BMS.GlobalData.ErrorMessages;
using BMS.GlobalData.Validation;

namespace WebApplication1.Models.MovementsInputModels
{
    public class ArrivalMovementInputModel
    {
        [Required(ErrorMessage =InvalidDepartureMovementErrorMessages.DepartureMovementIsRequired)]
        [RegularExpression(MessagesValidation.DepMVTMessageValidation,ErrorMessage = InvalidDepartureMovementErrorMessages.DepartureMovementIsInvalid)]
        public string Message { get; set; }
    }
}
