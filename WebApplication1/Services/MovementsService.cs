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

        public void CreateArrivalMovement(DateTime[] dates,string supplementaryInformation,InboundFlight inboundFlight)
        {
            var arrivalMovement = new ArrivalMovement
            {
                InboundFlightId = inboundFlight.FlightId,
                InboundFlight = inboundFlight,
                SupplementaryInformation = supplementaryInformation,
                TouchdownTime = dates[0],
                OnBlockTime = dates[1],
                DateOfMovement = DateTime.UtcNow
            };
            
            this.dbContext.ArrivalMovements.Add(arrivalMovement);
            this.dbContext.SaveChanges();

            inboundFlight.ArrivalMovementId = arrivalMovement.Id;
            this.dbContext.SaveChanges();
        }

        public void CreateDepartureMovement(DateTime[] dates, string supplementaryInformation, int totalPax, OutboundFlight outboundFlight)
        {
            var departureMovement = new DepartureMovement
            {
                OffBlockTime = dates[0],
                TakeoffTime = dates[1],
                SupplementaryInformation = supplementaryInformation,
                TotalPAX = totalPax,
                OutboundFlightId = outboundFlight.FlightId,
                OutboundFlight = outboundFlight,
                DateOfMovement = DateTime.UtcNow
            };
            this.dbContext.DepartureMovements.Add(departureMovement);
            this.dbContext.SaveChanges();

            outboundFlight.DepartureMovementId = departureMovement.Id;
            this.dbContext.SaveChanges();
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
