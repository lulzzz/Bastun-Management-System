namespace BMS.Services
{
    using BMS.Data.Models;
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class AircraftCabinService : IAircraftCabinService
    {
        private readonly ApplicationDbContext dbContext;

        public AircraftCabinService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public AircraftCabin AddCabinToAircraft(Aircraft aircraft)
        {
            var aircraftCabin = new AircraftCabin
            {
                AircraftId = aircraft.AircraftId,
               
            };

            switch (aircraft.Type.ToString())
            {
                case "B738":
                    this.SetCabinData738(aircraftCabin);
                    break;
                case "B752":
                    this.SetCabinData752(aircraftCabin);
                    break;
                case "B763":
                    this.SetCabinData763(aircraftCabin);
                    break;
                case "B788":
                    this.SetCabinData788(aircraftCabin);
                    break;
                case "B789":
                    this.SetCabinData789(aircraftCabin);
                    break;
                case "A320":
                    this.SetCabinData320(aircraftCabin);
                    break;
                default:
                    break;
            }

            return aircraftCabin; 
        }

        private void SetCabinData320(AircraftCabin cabin)
        {
            throw new NotImplementedException();
        }

        private void SetCabinData738(AircraftCabin cabin)
        {
            if (cabin != null)
            {
                cabin.ZoneAlphaCapacity = 60;
                cabin.ZoneBravoCapacity = 60;
                cabin.ZoneCharlieCapacity = 60;
                cabin.ZoneDeltaCapacity = 9;
            }
        }

        private void SetCabinData752(AircraftCabin cabin)
        {
            if (cabin != null)
            {
                cabin.ZoneAlphaCapacity = 51;
                cabin.ZoneBravoCapacity = 90;
                cabin.ZoneCharlieCapacity = 81;
            }   
        }

        private void SetCabinData763(AircraftCabin cabin)
        {
            if (cabin != null)
            {
                cabin.ZoneAlphaCapacity = 100;
                cabin.ZoneBravoCapacity = 125;
                cabin.ZoneCharlieCapacity = 103;
            }
        }

        private void SetCabinData788(AircraftCabin cabin)
        {
            if (cabin != null)
            {
                cabin.ZoneAlphaCapacity = 100;
                cabin.ZoneBravoCapacity = 125;
                cabin.ZoneDeltaCapacity = 100; 
            }
        }

        private void SetCabinData789(AircraftCabin cabin)
        {
            if (cabin != null)
            {
                cabin.ZoneAlphaCapacity = 120;
                cabin.ZoneBravoCapacity = 125;
                cabin.ZoneCharlieCapacity = 100;
            }
        }
    }
}
