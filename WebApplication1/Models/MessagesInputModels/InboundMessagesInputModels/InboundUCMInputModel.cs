namespace BMS.Models.MessagesInputModels.InboundMessagesInputModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    public class InboundUCMMessageModel
    {
        [Required]
        [RegularExpression()]
        public string Message { get; set; }
    }
}
