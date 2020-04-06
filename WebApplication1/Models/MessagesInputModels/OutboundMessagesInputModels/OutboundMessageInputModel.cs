namespace BMS.Models.MessagesInputModels.OutboundMessagesInputModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class OutboundMessageInputModel
    {
        [Required]
        public string LDMMessage { get; set; }

        [Required]
        public string CPMMessage { get; set; }

        [Required]
        public string UCMMessage { get; set; }
    }
}
