namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts.MovementContracts;
    using BMS.Models.MovementsInputModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IMessageParser
    {
        bool ParseArrivalMovement(string messageContent);

        bool ParseDepartureMovement(string messageContent);


        bool ParseInboundCPM(string messageContent);

        bool ParseOutboundCPM(string messageContent);

        bool ParseInboundLDM(string messageContent);

        bool ParseOutboundLDM(string messageContent);

        bool ParseInboundUCM(string messageContent);

        bool ParseOutboundUCM(string messageContent);
    }
}
