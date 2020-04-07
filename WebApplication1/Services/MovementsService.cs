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

        public void CreateArrivalMovement(Flight flight,DateTime[] dates,string supplementaryInformation)
        {
            var dateMovementCreatedOn = new DateTime(flight.STA.Year, flight.STA.Month, flight.STA.Day);

            var arrivalMovement = new ArrivalMovement
            {
                FlightRef = flight.FlightId,
                TouchdownTime = dates[0],
                OnBlockTime = dates[1],
                SupplementaryInformation = supplementaryInformation,
                DateOfMovement = dateMovementCreatedOn,
                Flight = flight
            };

            this.dbContext.ArrivalMovements.Add(arrivalMovement);
            this.dbContext.SaveChangesAsync();
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
