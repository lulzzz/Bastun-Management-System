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

        void ParseDepartureMovement(string messageContent);

        bool ParseLDM(string messageContent);

        bool ParseInboundCPM(string messageContent);

        void ParseUCM(string messageContent);


    }
}
