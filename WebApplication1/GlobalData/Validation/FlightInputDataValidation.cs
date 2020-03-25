namespace BMS.GlobalData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public static class FlightInputDataValidation
    {
        public const string FlightNumberValidation = @"^[A-Z]{1,4}\-[0-9]{1,4}$";

        public const string AircraftRegistrationValidation = @"^[A-Z]{1,2}\-[A-Z0-9]{1,10}$";

        //TODO: Make validation for each manufacturer 
        public const string AircraftTypeValidation = @"[B737]|[A320]";

        public const string AircraftVersionValidation = @"[Y][1][8][0-9]";
    }
}
