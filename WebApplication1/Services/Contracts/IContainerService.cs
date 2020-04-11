namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IContainerService
    {
        public List<Container> AddContainerToInboundFlight(InboundFlight inboundFlight,int amountOfInboundContainersToCreate);


        public List<ContainerInfo> CreateContainerInfo(string[] splitMessage,List<Container> containers);
    }
}
