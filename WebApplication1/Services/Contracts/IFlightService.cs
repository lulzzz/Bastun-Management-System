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
        InboundFlight GetInboundFlightByFlightNumber(string inboundFlightNumber);

        OutboundFlight GetOutboundFlightByFlightNumber(string outboundFlightNumber);

        void RegisterInboundFlight(FlightInputModel inboundFlightInputModel);

        void RegisterOutboundFlight(FlightInputModel outboundFlightInputModel);

        bool CheckIfFlightIsInbound(string flightNumber);

        bool CheckIfFlightIsOutbound(string flightNumber);

        void GetAllFlights();
    }
}
