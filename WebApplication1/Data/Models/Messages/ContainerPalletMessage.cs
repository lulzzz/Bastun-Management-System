namespace BMS.Data.Models.Messages
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class ContainerPalletMessage : Message
    {
        public ContainerPalletMessage()
        {
            this.ContainerInfo = new List<ContainerInfo>();
        }

        public int ContainerInfoId { get; set; }
        public virtual List<ContainerInfo> ContainerInfo { get; set; }

        public string SupplementaryInformation { get; set; }
    }
}
