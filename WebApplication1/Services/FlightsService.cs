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

    public class FlightsService : IFlightService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public FlightsService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        public void RegisterFlight(FlightInputModel flightInput)
        {
           var currentFlight = mapper.Map<Flight>(flightInput);
            this.dbContext.Flights.Add(currentFlight);
        }
    }
}
