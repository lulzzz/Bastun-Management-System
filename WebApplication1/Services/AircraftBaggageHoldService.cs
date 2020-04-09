namespace BMS.Services
{
    using BMS.Data.Models;
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class AircraftBaggageHoldService : IAircraftBaggageHoldService
    {
        private readonly ApplicationDbContext dbContext;

        public AircraftBaggageHoldService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public AircraftBaggageHold AddBaggageHoldToAircraft(Aircraft aircraft)
        {
            throw new NotImplementedException();
        }

        public void SetHoldData738(Aircraft aircraft)
        {
            throw new NotImplementedException();
        }

        public void SetHoldData752(Aircraft aircraft)
        {
            throw new NotImplementedException();
        }

        public void SetHoldData763(Aircraft aircraft)
        {
            throw new NotImplementedException();
        }

        public void SetHoldData788(Aircraft aircraft)
        {
            throw new NotImplementedException();
        }

        public void SetHoldData789(Aircraft aircraft)
        {
            throw new NotImplementedException();
        }
    }
}
