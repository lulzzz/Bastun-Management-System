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
        Flight GetFlightByFlightNumber(string flightNumber);

        void RegisterFlight(FlightInputModel flightInput);

        ICollection<Flight> GetAllFlights();
    }
}
