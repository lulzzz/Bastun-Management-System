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

        private void AddBaggageHoldToAircraft(Aircraft aircraft)
        {
            var aircraftBaggageHold = new AircraftBaggageHold
            {
                AircraftId = aircraft.AircraftId,
                Aircraft = aircraft
            };

            switch (aircraft.Type.ToString())
            {
                case "B738":
                    this.SetHoldData738(aircraftBaggageHold);
                    break;
                case "B752":
                    this.SetHoldData752(aircraftBaggageHold);
                    break;
                case "B763":
                    this.SetHoldData763(aircraftBaggageHold);
                    break;
                case "B788":
                    this.SetHoldData788(aircraftBaggageHold);
                    break;
                case "B789":
                    this.SetHoldData789(aircraftBaggageHold);
                    break;
                case "A320":
                    this.SetHoldData320(aircraftBaggageHold);
                    break;
                default:
                    break;
            }

            this.dbContext.AircraftBaggageHolds.Add(aircraftBaggageHold);
            this.dbContext.SaveChanges();
        }

        private void SetHoldData738(AircraftBaggageHold baggageHold)
        {
            throw new NotImplementedException();
        }

        private void SetHoldData752(AircraftBaggageHold baggageHold)
        {
            baggageHold.CompartmentOneCapacity = 800;
            baggageHold.CompartmentTwoCapacity = 3464;
            baggageHold.CompartmentThreeCapacity = 2810;
            baggageHold.CompartmentFourCapacity = 1699;
            baggageHold.CompartmentFiveCapacity = 2476;
        }

        private void SetHoldData763(AircraftBaggageHold baggageHold)
        {
            baggageHold.CompartmentOneCapacity = 3500;
            baggageHold.CompartmentTwoCapacity = 3500;
            baggageHold.CompartmentThreeCapacity = 4500;
            baggageHold.CompartmentFourCapacity = 4500;
            baggageHold.CompartmentFiveCapacity = 1000;
        }

        private void SetHoldData788(AircraftBaggageHold baggageHold)
        {
           
        }

        private void SetHoldData789(AircraftBaggageHold baggageHold)
        {
          
        }

        private void SetHoldData320(AircraftBaggageHold baggageHold)
        {

        }
    }
}
