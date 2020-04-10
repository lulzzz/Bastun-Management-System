namespace BMS.Services.Utility
{
    using BMS.Services.Contracts;
    using BMS.Services.Utility.UtilityContracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class FlightDataValidation : IFlightDataValidation
    {
        private readonly IFlightService flightService;
        private readonly IAircraftService aircraftService;
        private const string _hyphen = "-";

        public FlightDataValidation(IFlightService flightService, IAircraftService aircraftService)
        {
            this.flightService = flightService;
            this.aircraftService = aircraftService;
        }
   
        public bool IsFlightNumberAndRegistrationValid(string flightNumber, string registration)
        {
            bool flag = true;
            if (this.flightService.CheckFlightNumber(flightNumber))
            {
                if (!this.aircraftService.CheckAircraftRegistration(registration))
                {
                   
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool IsDateAndStationValid(string flightNumber,string date, string station)
        {
            bool flag = true;

            var flightfromdb = this.flightService.GetInboundFlightByFlightNumber(flightNumber);

            if (flightfromdb.Origin != station || flightfromdb.STA.Day.ToString() != date)
            {
                flag = false;
            }

           
            return flag;
        }
        
    }
}
