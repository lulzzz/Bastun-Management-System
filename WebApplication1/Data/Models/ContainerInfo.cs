namespace BMS.Data.Models
{
    using BMS.Data.Models.Messages;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class ContainerInfo
    {
        [Key]
        public int ContainerInfoId { get; set; }

        public int ContainerId { get; set; }

        public virtual Container Container { get; set; }

        public int ContainerPalletMessageId { get; set; }

        public virtual ContainerPalletMessage ContainerPalletMessage { get; set; }

        public int UniloadContainerMessageId { get; set; }

        public virtual UniloadContainerMessage UniloadContainerMessage { get; set; }

        public string ContainerPosition { get; set; }

        public int ContainerNumberAndType { get; set; }

        public int ContainerTotalWeight { get; set; }
    }
}
