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
            string newFlnmb = GetCorrectFlightNumber(flightNumber);
            if (this.flightService.CheckFlightNumber(newFlnmb))
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
            //string newFlnmb = GetCorrectFlightNumber(flightNumber);
            //var flightFromDb = this.flightService.GetFlightByFlightNumber(newFlnmb);

            //if (flightFromDb.Origin != station || flightFromDb.STA.Day.ToString() != date)
            //{
            //    flag = false;
            //}


            return flag;
        }
        
        public string GetCorrectFlightNumber(string flightNumber)
        {
            string result = string.Empty;
            int index = 0;
            for (int i = 0; i < flightNumber.Length; i++)
            {
                if (char.IsDigit(flightNumber[i]))
                {
                    index = i;
                    break;
                }
            }
            result = flightNumber.Insert(index, _hyphen);
            return result;
        }

        private string GetCorrectRegistration(string registration)
        {
            string result = registration.Insert(1, _hyphen);
            return result;
        }
    }
}
