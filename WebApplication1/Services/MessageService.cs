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

    public class MessageService : IMessageService
    {
        private readonly ApplicationDbContext dbContext;

        public MessageService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
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

        public void CreateInboundLDM()
        {
            throw new NotImplementedException();
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
