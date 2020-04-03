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
            var flightToAdd = new Flight
            {
                FlightNumber = flightInput.FlightNumber,
                Origin = flightInput.Origin,
                Destination = flightInput.Destination,
                STA = flightInput.STA,
                STD = flightInput.STD,
                BookedPax = flightInput.BookedPax
            };
            this.dbContext.Flights.Add(flightToAdd);
            this.dbContext.SaveChanges();
        }

        public Flight GetFlightByFlightNumber(string flightNumber)
        {
            var flightFromDb =
                this.dbContext.Flights
                 .Where(x => x.FlightNumber == flightNumber)
                 .FirstOrDefault();

            return flightFromDb;
        }

        public List<FlightInputModel> GetAllFlights()
        {
            return null;
        }

        public void RegisterAircraft(AircraftInputModel aircraftInputModel, Flight flight)
        {
            var currAircraft = new Aircraft
            {
                AircraftRegistration = aircraftInputModel.AircraftRegistration,
                Type = aircraftInputModel.Type,
                Version = aircraftInputModel.Version,
                Cabin = new AircraftCabin(),
                FlightId = flight.FlightId,
                Flight = flight
            };

            this.dbContext.Aircraft.Add(currAircraft);
            this.dbContext.SaveChanges();
        }
    }
}
