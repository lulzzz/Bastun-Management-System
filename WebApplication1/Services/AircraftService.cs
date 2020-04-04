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

        public AircraftService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void RegisterAircraft(AircraftInputModel aircraftInputModel, Flight flight)
        {
            var currAircraft = new Aircraft
            {
                AircraftRegistration = aircraftInputModel.AircraftRegistration,
                Type = aircraftInputModel.Type,
                Version = aircraftInputModel.Version,
                Cabin = new AircraftCabin(),
                Flight = flight,
                FlightId = flight.FlightId,
            };
           
            this.dbContext.Aircraft.Add(currAircraft);
            this.dbContext.SaveChanges();
        }
    }
}
