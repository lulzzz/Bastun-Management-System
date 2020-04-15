namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts.FlightContracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IContainerService
    {
        public List<Container> AddContainersToInboundFlight(InboundFlight inbound,int amountOfInboundContainersToCreate);

        public List<Container> AddContainersToOutboundFlight(OutboundFlight outbond, int amountOfOutboundContainersToCreate);


        public List<ContainerInfo> CreateContainerInfo(string[] splitMessage,List<Container> containers);
    }
}
