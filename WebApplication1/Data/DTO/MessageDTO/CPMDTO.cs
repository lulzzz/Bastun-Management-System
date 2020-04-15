namespace BMS.Data.DTO
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CPMDTO
    {
        public CPMDTO(List<ContainerInfo> containerInfo, string supplementaryInformation)
        {
            this.ContainerInfo = containerInfo;
            this.SupplementaryInformation = supplementaryInformation;
        }

        public List<ContainerInfo> ContainerInfo { get; set; }

        public string SupplementaryInformation { get; set; }
    }
}
