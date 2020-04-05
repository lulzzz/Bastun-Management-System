namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts.MovementContracts;
    using BMS.Data.Models.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IMessageParser
    {
        ArrivalMovement ParseArrivalMovement(string messageContent);

        DepartureMovement ParseDepartureMovement(string messageContent);

        LoadDistributionMessage ParseLDM(string messageContent);

        ContainerPalletMessage ParseCPM(string messageContent);


    }
}
