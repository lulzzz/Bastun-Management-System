namespace BMS.Services
{
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BMS.Models;
    using WebApplication1.Data;
    using BMS.Data.Models;
    using BMS.Data.Models.Messages;
    using BMS.Data.DTO;
    using AutoMapper;

    public class MessageService : IMessageService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public MessageService(ApplicationDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public void CreateInboundCPM(List<ContainerInfo> containers,InboundFlight inboundFlight,string supplementaryInformation)
        {
            var containerPalletMessage = new ContainerPalletMessage
            {
                InboundFlightId = inboundFlight.FlightId,
                InboundFlight = inboundFlight,
                ContainerInfo = containers,
                SupplementaryInformation = supplementaryInformation
            };

            this.dbContext.ContainerPalletMessages.Add(containerPalletMessage);
            this.dbContext.SaveChanges();

        }

        public void CreateInboundLDM(InboundFlight inboundFlight, LDMDTO ldmDTO)
        {
            var loadDistributionMessage = mapper.Map<LoadDistributionMessage>(ldmDTO);
            this.dbContext.LoadDistributionMessages.Add(loadDistributionMessage);
            this.dbContext.SaveChanges();

            loadDistributionMessage.InboundFlight = inboundFlight;
            loadDistributionMessage.InboundFlightId = inboundFlight.FlightId;
            this.dbContext.SaveChanges();
        }

        public void CreateOutboundCPM(List<ContainerInfo> containers, OutboundFlight outboundFlight, string supplementaryInformation)
        {
            throw new NotImplementedException();
        }

        public void CreateOutboundLDM()
        {
            throw new NotImplementedException();
        }

        public void CreateUCM()
        {
            throw new NotImplementedException();
        }
    }
}
