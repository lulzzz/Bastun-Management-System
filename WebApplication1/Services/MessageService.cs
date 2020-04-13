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

        public void CreateInboundCPM(InboundFlight inbound, CPMDTO dto)
        {
            var inboundContainerPalletMessage = this.mapper.Map<ContainerPalletMessage>(dto);
            this.dbContext.ContainerPalletMessages.Add(inboundContainerPalletMessage);
            this.dbContext.SaveChanges();

            inboundContainerPalletMessage.InboundFlight = inbound;
            inboundContainerPalletMessage.InboundFlightId = inbound.FlightId;
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

        public void CreateOutboundCPM(OutboundFlight outboundFlight, CPMDTO dto)
        {
            var outboundContainerPalletMessage = mapper.Map<ContainerPalletMessage>(dto);
            this.dbContext.ContainerPalletMessages.Add(outboundContainerPalletMessage);
            this.dbContext.SaveChanges();

            outboundContainerPalletMessage.OutboundFlight = outboundFlight;
            outboundContainerPalletMessage.OutboundFlightId = outboundFlight.FlightId;
            outboundFlight.OutboundMessages.Add(outboundContainerPalletMessage);
            this.dbContext.SaveChanges();
        }

        public void CreateOutboundLDM(OutboundFlight outboundFlight, LDMDTO  dto)
        {
            var outboundLoadDistributionMessage = this.mapper.Map<LoadDistributionMessage>(dto);
            this.dbContext.LoadDistributionMessages.Add(outboundLoadDistributionMessage);
            this.dbContext.SaveChanges();

            outboundLoadDistributionMessage.OutboundFlight = outboundFlight;
            outboundLoadDistributionMessage.OutboundFlightId = outboundFlight.FlightId;
            this.dbContext.SaveChanges();
        }

    }
}
