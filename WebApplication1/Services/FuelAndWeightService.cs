namespace BMS.Services
{
    using AutoMapper;
    using BMS.Data.Models;
    using BMS.Models;
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class FuelAndWeightService : IFuelAndWeightService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IFlightService flightService;
        private readonly IMapper mapper;

        public FuelAndWeightService(ApplicationDbContext dbContext, IFlightService flightService, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.flightService = flightService;
            this.mapper = mapper;
        }
        public void AddFuelForm(FuelFormInputModel fuelFormInputModel)
        {
            var outboundFlight = this.flightService.GetOutboundFlightByFlightNumber(fuelFormInputModel.FlightNumber);
            if (outboundFlight.Aircraft != null)
            {
                var newFuelForm = this.mapper.Map<FuelForm>(fuelFormInputModel);

                newFuelForm.Aircraft = outboundFlight.Aircraft;
                newFuelForm.AircraftId = outboundFlight.AircraftId;

                this.dbContext.FuelForms.Add(newFuelForm);
                this.dbContext.SaveChanges();

                outboundFlight.Aircraft.FuelForm = newFuelForm;
                outboundFlight.Aircraft.FuelFormId = newFuelForm.Id;
            }
        }

        public void AddWeightForm(WeightFormInputModel weightInputModel)
        {
            var outboundFlight = this.flightService.GetOutboundFlightByFlightNumber(weightInputModel.FlightNumber);

            if (outboundFlight != null)
            {
                
            }
        }
    }
}
