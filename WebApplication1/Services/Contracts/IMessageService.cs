namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IMessageService
    {
        public void CreateLDM();

        public void CreateInboundCPM(List<ContainerInfo> containers, InboundFlight inboundFlight,string supplementaryInformation);

        public void CreateUCM();
    }
}
