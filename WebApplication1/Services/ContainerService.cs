namespace BMS.Services
{
    using BMS.Data.Models;
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class ContainerService : IContainerService
    {
        private readonly ApplicationDbContext dbContext;

        public ContainerService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Container> AddContainerToInboundFlight(InboundFlight inboundFlight,int amountOfContainersToCreate)
        {
            var listOfContainers = new List<Container>();

            for (int i = 0; i < amountOfContainersToCreate; i++)
            {
                var container = new Container
                {
                    InboundFlight = inboundFlight,
                    InboundFlightId = inboundFlight.FlightId,

                };

                listOfContainers.Add(container);
                this.dbContext.Containers.Add(container);
                this.dbContext.SaveChanges();
            }

            return listOfContainers;
        }

        public List<ContainerInfo> CreateContainerInfo(string[] splitMessage,List<Container> containers)
        {
            var listOfContainerInfo = new List<ContainerInfo>();
            int index = 0;
            for (int i = 2; i < splitMessage.Length - 1; i++)
            {
                string currContainerInfo = splitMessage[i];
                string[] splitDataForCurrContainer =
                    currContainerInfo.Split(new string[] { "/", "-" }, StringSplitOptions.RemoveEmptyEntries);

                var currentContainer = containers[index];
                var currentContainerInfo = new ContainerInfo
                {
                    ContainerPosition = splitDataForCurrContainer[0],
                    ContainerNumberAndType = splitDataForCurrContainer[1],
                    ContainerTotalWeight = int.Parse(splitDataForCurrContainer[2]),
                    ContainerId = currentContainer.ContainerId,
                    Container = currentContainer
                };
                listOfContainerInfo.Add(currentContainerInfo);

                this.dbContext.ContainerInfos.Add(currentContainerInfo);
                this.dbContext.SaveChanges();
                index++;
            }
            return listOfContainerInfo;
        }
    }
}
