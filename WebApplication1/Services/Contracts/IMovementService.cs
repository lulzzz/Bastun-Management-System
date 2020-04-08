namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IMovementService
    {
        void CreateArrivalMovement(DateTime[] dates, string supplementaryInformation);

        void CreateDepartureMovement(DateTime[] dates, string supplementaryInformation, int totalPax);

        ArrivalMovement GetArrivalMovementByFlightNumber(string flightNumber);

        DepartureMovement GetDepartureMovementByFlightNumber(string flightNumber);
    }
}
