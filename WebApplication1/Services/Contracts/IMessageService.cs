namespace BMS.Services.Contracts
{
    using BMS.Data.DTO;
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts.FlightContracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IMessageService
    {
        public void CreateInboundLDM(InboundFlight inbound,LDMDTO inboundLDMDTO);

        public void CreateOutboundLDM(OutboundFlight outbound, LDMDTO outboundLDMDTO);

        public void CreateInboundCPM(InboundFlight inbound, CPMDTO inboundCPMDTO);

        public void CreateOutboundCPM(OutboundFlight outboundFlight,CPMDTO outboundCPMDTO);

    }
}
