namespace BMS.GlobalData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public static class FlightInputDataValidation
    {
        public const string FlightNumberValidationForInputForm = @"(?<inbound>[A-Z]{1,5}[0-9]{1,5})\/(?<outbound>[A-Z]{1,5}[0-9]{1,5})";

        public const string GeneralFlightNumberValidation = @"[A-Z]{1,5}[0-9]{1,5}";

        public const string AircraftRegistrationValidation = @"^[A-Z]{1,2}[A-Z]{1,10}$";

        //TODO: Make validation for each manufacturer 
        public const string AircraftTypeValidation = @"[A-Z]{1}[0-9]{3}";

        public const string AircraftVersionValidation = @"(?<version>[Y][0-9]{1,3})";

        public const string StationValidation = @"^[A-Z]{3}$";

       
    }
}
