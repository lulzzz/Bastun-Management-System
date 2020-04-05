namespace BMS.Services
{
    using BMS.Data.Models;
    using BMS.Data.Models.Messages;
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class MessageParser : IMessageParser
    {
        public ArrivalMovement ParseArrivalMovement(string messageContent)
        {
            throw new NotImplementedException();
        }

        public ContainerPalletMessage ParseCPM(string messageContent)
        {
            throw new NotImplementedException();
        }

        public DepartureMovement ParseDepartureMovement(string messageContent)
        {
            throw new NotImplementedException();
        }

        public LoadDistributionMessage ParseLDM(string messageContent)
        {
            throw new NotImplementedException();
        }
    }
}
