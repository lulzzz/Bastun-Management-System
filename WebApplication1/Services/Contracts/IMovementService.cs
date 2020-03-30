namespace BMS.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IMovementService
    {
        void GetArrivalMovementByFlightNumber(string flightNumber);

        void GetDepartureMovementByFlightNumber(string flightNumber);
    }
}
