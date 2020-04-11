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

        public void CreateInboundCPM(ICollection<ContainerInfo> containers,InboundFlight inboundFlight)
        {
            var containerPalletMessage = new ContainerPalletMessage
            {
                InboundFlightId = inboundFlight.FlightId,
                InboundFlight = inboundFlight,
                ContainerInfo = containers,
            };

            this.dbContext.ContainerPalletMessages.Add(containerPalletMessage);
            this.dbContext.SaveChanges();

            inboundFlight.InboundMessages.Add(containerPalletMessage);
        }

        public void CreateLDM()
        {
            throw new NotImplementedException();
        }

        public void CreateUCM()
        {
            throw new NotImplementedException();
        }

       
    }
}
