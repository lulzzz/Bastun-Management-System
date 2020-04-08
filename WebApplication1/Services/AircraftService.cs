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

        public bool CheckAircraftRegistration(string registration)
        {
            return this.dbContext.Aircraft.Any(x => x.AircraftRegistration == registration);
        }

        public void RegisterAircraft(AircraftInputModel aircraftInputModel)
        {
           
        }
    }
}
