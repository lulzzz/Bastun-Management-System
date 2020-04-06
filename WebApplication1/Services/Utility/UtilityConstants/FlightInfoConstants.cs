namespace BMS.Services.Utility.UtilityConstants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class FlightInfoConstants
    {
        public const string IsFlightInfoValid = @"(?<flt>[A-Z]{1,4}[0-9]{1,5})\/(?<date>[0-9]{2})\.(?<registration>[A-Z]{1,5})\.(?<station>[A-Z]{3})";
    }
}
