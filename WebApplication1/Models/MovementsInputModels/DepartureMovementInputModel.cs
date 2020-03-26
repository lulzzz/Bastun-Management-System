using BMS.GlobalData.ErrorMessages;
using BMS.GlobalData.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Models.MovementsInputModels
{
    public class DepartureMovementInputModel
    {
        [Required(ErrorMessage = InvalidDepartureMovementErrorMessages.DepartureMovementIsRequired)]
        [RegularExpression(MessagesValidation.DepMVTMessageValidation,ErrorMessage = InvalidDepartureMovementErrorMessages.DepartureMovementIsInvalid)]
        public string Message { get; set; }
    }
}
