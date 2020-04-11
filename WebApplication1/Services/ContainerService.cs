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

        public void AddContainerToInboundFlight(InboundFlight inboundFlight,int amountOfContainersToCreate)
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

            foreach (var container in listOfContainers)
            {
                inboundFlight.InboundContainers.Add(container);
            }
        }

        public List<ContainerInfo> CreateContainerInfo(string[] splitMessage)
        {
            var listOfContainerInfo = new List<ContainerInfo>();

            for (int i = 2; i < splitMessage.Length - 1; i++)
            {
                string currContainer = splitMessage[i];
                string[] splitDataForCurrContainer =
                    currContainer.Split(new string[] { "/", "-" }, StringSplitOptions.RemoveEmptyEntries);

                var currentContainerInfo = new ContainerInfo
                {
                    ContainerPosition = splitDataForCurrContainer[0],
                    ContainerNumberAndType = splitDataForCurrContainer[1],
                    ContainerTotalWeight = int.Parse(splitDataForCurrContainer[2])
                };
                listOfContainerInfo.Add(currentContainerInfo);

                this.dbContext.ContainerInfos.Add(currentContainerInfo);
                this.dbContext.SaveChanges();
            }

            return listOfContainerInfo;
        }

        public void MapContainerInfoToInboundFlightContainers(InboundFlight inboundFlight, List<ContainerInfo> containerInfos)
        {
            var listOfInboundFlightContainers = inboundFlight.InboundContainers.ToList();

            for (int i = 0; i < containerInfos.Count; i++)
            {
                var currentContainerForInboundFlight = listOfInboundFlightContainers[i];
                var currentContainerInfo = containerInfos[i];

                currentContainerInfo.Container = currentContainerForInboundFlight;
                currentContainerInfo.ContainerId = currentContainerForInboundFlight.ContainerId;

                currentContainerForInboundFlight.ContainerInfo = currentContainerInfo;
                currentContainerForInboundFlight.ContainerInfoId = currentContainerInfo.ContainerInfoId;
            }
        }
    }
}
