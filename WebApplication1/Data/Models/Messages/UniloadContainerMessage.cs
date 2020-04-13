namespace BMS.Data.Models.Messages
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class UniloadContainerMessage : Message
    {
        public UniloadContainerMessage()
        {
            this.InboundContainerInfo = new List<ContainerInfo>();
            this.OutboundContainerInfo = new List<ContainerInfo>();
        }

        public virtual ICollection<ContainerInfo> InboundContainerInfo { get; set; }

        public virtual ICollection<ContainerInfo> OutboundContainerInfo { get; set; }
    }
}
