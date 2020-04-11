namespace BMS.Models.MovementsInputModels
{
    using BMS.GlobalData.ErrorMessages;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class MovementInputModel
    {
        [Required(ErrorMessage = InvalidErrorMessages.MovementIsRequired)]
        public string Movement { get; set; }
    }
}
