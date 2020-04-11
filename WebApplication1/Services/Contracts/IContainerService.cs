namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IContainerService
    {
        public void AddContainerToInboundFlight(InboundFlight inboundFlight,int amountOfInboundContainersToCreate);

        public void MapContainerInfoToInboundFlightContainers(InboundFlight inboundFlight, List<ContainerInfo> containerInfos);

        List<ContainerInfo> CreateContainerInfo(string[] splitMessage);
    }
}
