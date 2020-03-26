namespace BMS.Services
{
    using BMS.Models;
    using BMS.Services.Contracts;
    using AutoMapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts;
    using Microsoft.EntityFrameworkCore;

    public class FlightsService : IFlightService
    {
        private readonly ApplicationDbContext dbContext;
        public FlightsService(ApplicationDbContext dbContext)
        {
        
            this.dbContext = dbContext;
        }

        public void RegisterFlight(FlightInputModel flightInput)
        {
            var currFlightToAdd = new Flight
            {
                FlightNumber = flightInput.FlightNumber,
                ACType = flightInput.ACType,
                AircraftRegistration = flightInput.AircraftRegistration,
                Version = flightInput.Version,
                Origin = flightInput.Origin,
                Destination = flightInput.Destination,
                STA = flightInput.STA,
                STD = flightInput.STD,
                BookedPax = flightInput.BookedPax
            };

            this.dbContext.Flights.Add(currFlightToAdd);
            this.dbContext.SaveChanges();
        }

        public List<FlightInputModel> GetAllFlights()
        {
            var allFlightsFromDb =
                this
                .dbContext
                .Flights
                .Select(fvm => new FlightInputModel
                {
                    FlightNumber = fvm.FlightNumber,
                    ACType = fvm.ACType,
                    AircraftRegistration = fvm.AircraftRegistration,
                    Origin = fvm.Origin,
                    Destination = fvm.Destination,
                    Version = fvm.Version,
                    STA = fvm.STA,
                    STD = fvm.STD,
                    BookedPax = fvm.BookedPax
                })
                .ToList();


            return allFlightsFromDb;
        }
    }
}
