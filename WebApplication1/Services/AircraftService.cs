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
        private readonly IAircraftCabinService cabinService;

        public AircraftService(ApplicationDbContext dbContext, IFlightService flightService, IAircraftCabinService cabinService)
        {
            this.dbContext = dbContext;
            this.flightService = flightService;
            this.cabinService = cabinService;
        }

        public bool CheckAircraftRegistration(string registration)
        {
            return this.dbContext.Aircraft.Any(x => x.AircraftRegistration == registration);
        }

        public bool IsAircraftGoingToBeContainerized(string aircraftType)
        {
            if (aircraftType == "763" || aircraftType == "788" || aircraftType == "789")
            {
                return true;
            }

            return false;
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

                newAircraft.IsAicraftContainerized = this.IsAircraftGoingToBeContainerized(newAircraft.Type.ToString());
                newAircraft.Cabin = this.cabinService.AddCabinToAircraft(newAircraft);
                this.dbContext.Aircraft.Add(newAircraft);
                this.dbContext.SaveChanges();
            }

           
        }
    }
}
