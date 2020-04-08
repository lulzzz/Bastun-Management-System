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
            this.ContainerInfo = new List<ContainerInfo>();
        }

        public virtual ICollection<ContainerInfo> ContainerInfo { get; set; }
    }
}
