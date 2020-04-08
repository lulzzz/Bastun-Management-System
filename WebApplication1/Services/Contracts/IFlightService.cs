namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using BMS.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IFlightService
    {
        void GetFlightByFlightNumber(string flightNumber);

        void RegisterFlight(FlightInputModel flightInput);

        bool CheckFlightNumber(string flightNumber);

       void GetAllFlights();
    }
}
