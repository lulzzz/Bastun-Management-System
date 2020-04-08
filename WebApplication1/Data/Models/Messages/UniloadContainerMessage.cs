namespace BMS.Data.Models.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class UniloadContainerMessage : Message
    {
        public UniloadContainerMessage()
        {
            this.InboundContainerNumbers = new List<string>();
            this.OutboundContainerNumbers = new List<string>();
        }

        public ICollection<string> InboundContainerNumbers { get; set; }

        public ICollection<string> OutboundContainerNumbers { get; set; }
    }
}
