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
           
        }

        public List<FlightInputModel> GetAllFlights()
        {
            return null;
        }
    }
}
