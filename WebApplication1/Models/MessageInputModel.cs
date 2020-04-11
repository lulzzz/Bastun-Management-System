namespace BMS.Models
{
    using BMS.GlobalData.ErrorMessages;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class MessageInputModel
    {
        [Required(ErrorMessage = InvalidErrorMessages.MessageIsRequired)]
        public string Message { get; set; }
    }
}
