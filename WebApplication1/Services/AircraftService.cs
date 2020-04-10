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
        private readonly IAircraftBaggageHoldService baggageHoldService;

        public AircraftService(ApplicationDbContext dbContext, IFlightService flightService, IAircraftCabinService cabinService, IAircraftBaggageHoldService baggageHoldService)
        {
            this.dbContext = dbContext;
            this.flightService = flightService;
            this.cabinService = cabinService;
            this.baggageHoldService = baggageHoldService;
        }

        public bool CheckAircraftRegistration(string registration)
        {
            return this.dbContext.Aircraft.Any(x => x.AircraftRegistration == registration);
        }

        public bool IsAircraftGoingToBeContainerized(string aircraftType)
        {
            if (aircraftType == "B763" || aircraftType == "B788" || aircraftType == "B789")
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
                };

                newAircraft.IsAicraftContainerized = this.IsAircraftGoingToBeContainerized(newAircraft.Type.ToString());
                this.dbContext.Aircraft.Add(newAircraft);
                this.dbContext.SaveChanges();

                this.AddCabinAndBaggageHoldToAircraft(aircraftInputModel.AircraftRegistration);
            }
        }


        public Aircraft GetAicraftByRegistration(string registration)
        {

            var aircrafToReturn = this.dbContext.Aircraft.FirstOrDefault(x => x.AircraftRegistration == registration);

            return aircrafToReturn;
        }

       
        private void AddCabinAndBaggageHoldToAircraft(string registration)
        {
            var aircraft = this.GetAicraftByRegistration(registration);

            aircraft.Cabin = this.cabinService.AddCabinToAircraft(aircraft);
            aircraft.BaggageHold = this.baggageHoldService.AddBaggageHoldToAircraft(aircraft);
        }
    }
}
