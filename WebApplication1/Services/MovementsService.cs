namespace BMS.Services
{
    using BMS.Data.Models;
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class MovementsService : IMovementService
    {
        private readonly ApplicationDbContext dbContext;

        public MovementsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateArrivalMovement()
        {
           
        }

        public void CreateDepartureMovement()
        {
           
        }

        public ArrivalMovement GetArrivalMovementByFlightNumber(string flightNumber)
        {
            return null;
        }

        public DepartureMovement GetDepartureMovementByFlightNumber(string flightNumber)
        {
            return null; 
        }
    }
}
