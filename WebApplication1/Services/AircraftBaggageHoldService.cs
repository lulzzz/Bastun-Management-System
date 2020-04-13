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

        public AircraftBaggageHold AddBaggageHoldToAircraft(Aircraft aircraft)
        {
            var aircraftBaggageHold = new AircraftBaggageHold
            {
                AircraftId = aircraft.AircraftId
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
            aircraft.AircraftBaggageHoldId = aircraftBaggageHold.BaggageHoldId;
            this.dbContext.SaveChanges();

            return aircraftBaggageHold;
        }

        private void SetHoldData738(AircraftBaggageHold baggageHold)
        {
            baggageHold.CompartmentOneCapacity = 900;
            baggageHold.CompartmentTwoCapacity = 1800;
            baggageHold.CompartmentThreeCapacity = 2800;
            baggageHold.CompartmentFourCapacity = 1000;
            baggageHold.CompartmentFiveCapacity = 0;
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
            baggageHold.CompartmentOneCapacity = 4500;
            baggageHold.CompartmentTwoCapacity = 4500;
            baggageHold.CompartmentThreeCapacity = 5500;
            baggageHold.CompartmentFourCapacity = 5500;
            baggageHold.CompartmentFiveCapacity = 2000;
        }

        private void SetHoldData789(AircraftBaggageHold baggageHold)
        {
            baggageHold.CompartmentOneCapacity = 4700;
            baggageHold.CompartmentTwoCapacity = 4800;
            baggageHold.CompartmentThreeCapacity = 6000;
            baggageHold.CompartmentFourCapacity = 6000;
            baggageHold.CompartmentFiveCapacity = 2300;
        }

        private void SetHoldData320(AircraftBaggageHold baggageHold)
        {
            baggageHold.CompartmentOneCapacity = 1000;
            baggageHold.CompartmentTwoCapacity = 2300;
            baggageHold.CompartmentThreeCapacity = 3400;
            baggageHold.CompartmentFourCapacity = 3500;
            baggageHold.CompartmentFiveCapacity = 800;
        }
    }
}
