namespace BMS.Services
{
    using BMS.Data.Models;
    using BMS.Models;
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class AircraftService : IAircraftService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IFlightService flightService;

        public AircraftService(ApplicationDbContext dbContext, IFlightService flightService)
        {
            this.dbContext = dbContext;
            this.flightService = flightService;
        }

        public bool CheckAircraftRegistration(string registration)
        {
            return this.dbContext.Aircraft.Any(x => x.AircraftRegistration == registration);
        }

        public void RegisterAircraft(AircraftInputModel aircraftInputModel)
        {
            var outboundFlightToRegisterAircraftTo = this.flightService.GetOutboundFlightByFlightNumber(aircraftInputModel.FlightNumber);

            if (outboundFlightToRegisterAircraftTo != null)
            {
                var newAircraft = new Aircraft
                {
                    AircraftRegistration = aircraftInputModel.AircraftRegistration,
                    Version = aircraftInputModel.Version,
                    Type = aircraftInputModel.Type,
                    OutboundFlightId = outboundFlightToRegisterAircraftTo.FlightId,
                    OutboundFlight = outboundFlightToRegisterAircraftTo
                };

            string typeAsString = aircraftInputModel.Type.ToString();

                if (typeAsString == "B763" || typeAsString == "B788" || typeAsString == "B789")
                {
                    newAircraft.IsAicraftContainerized = true;
                } 
                else
                {
                    newAircraft.IsAicraftContainerized = false;
                }

                this.dbContext.Aircraft.Add(newAircraft);
                this.dbContext.SaveChanges();
            }

           
        }
    }
}
