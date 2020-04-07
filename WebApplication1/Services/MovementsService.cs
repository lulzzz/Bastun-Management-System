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
        private readonly IFlightService flightService;

        public MovementsService(ApplicationDbContext dbContext, IFlightService flightService)
        {
            this.dbContext = dbContext;
            this.flightService = flightService;
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
            this.dbContext.SaveChanges();
        }

        public void CreateDepartureMovement(Flight flight,DateTime[] dates, string supplementaryInformation, int totalPax)
        {
            var dateOfDepartureMovementCreation = new DateTime(flight.STD.Year, flight.STD.Month, flight.STD.Day);
            var departureMovement = new DepartureMovement
            {
                FlightRef = flight.FlightId,
                Flight = flight,
                DateOfMovement = dateOfDepartureMovementCreation,
                OffBlockTime = dates[0],
                TakeoffTime = dates[1],
                TotalPAX = totalPax,
                SupplementaryInformation = supplementaryInformation
            };
            this.dbContext.DepartureMovements.Add(departureMovement);
            this.dbContext.SaveChanges();
        }

        public ArrivalMovement GetArrivalMovementByFlightNumber(string flightNumber)
        {
            var flight = this.flightService.GetFlightByFlightNumber(flightNumber);
            return flight.ArrivalMovement;
        }

        public DepartureMovement GetDepartureMovementByFlightNumber(string flightNumber)
        {
            var flight = this.flightService.GetFlightByFlightNumber(flightNumber);
            return flight.DepartureMovement;
        }
    }
}
