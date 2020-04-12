namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IMessageService
    {
        public void CreateInboundLDM();

        public void CreateOutboundLDM();

        public void CreateInboundCPM(List<ContainerInfo> containers, InboundFlight inboundFlight,string supplementaryInformation);

        public void CreateOutboundCPM(List<ContainerInfo> containers, OutboundFlight outboundFlight, string supplementaryInformation);

        public void CreateUCM();
    }
}
