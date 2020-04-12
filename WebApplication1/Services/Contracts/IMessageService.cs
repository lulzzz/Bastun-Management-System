namespace BMS.Services.Contracts
{
    using BMS.Data.DTO;
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IMessageService
    {
        public void CreateInboundLDM(InboundFlight inbound,LDMDTO inboundLDMDTO);

        public void CreateOutboundLDM();

        public void CreateInboundCPM(List<ContainerInfo> containers, InboundFlight inboundFlight,string supplementaryInformation);

        public void CreateOutboundCPM(OutboundFlight outboundFlight,CPMDTO dto);

        public void CreateUCM();
    }
}
