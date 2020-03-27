﻿namespace BMS.Models.MessagesInputModels.OutboundMessagesInputModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    public class OutboundUCMInputModel
    {
        [Required]
        [RegularExpression()]
        public string Message { get; set; }
    }
}
