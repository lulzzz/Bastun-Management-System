namespace BMS.Services.Utility.UtilityConstants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class FlightInfoConstants
    {
        public const string IsFlightInfoValid = @"(?<flt>[A-Z]{1,4}[0-9]{1,5})\/(?<date>[0-9]{1,2})\.(?<reg>[A-Z0-9]{5,10})\.(?<origin>[A-Z]{3})";

        public const string IsLDMFlightInfoValid = @"(?<flt>[A-Z]{1,3}[0-9]{1,5})\/(?<date>[0-9]{1,2})\.(?<reg>[A-Z0-9]{1,5})\.(?<config>[A-Z]{1}[0-9]{3})\.(?<crewConfig>[0-9]{1,5}\/[0-9]{1,16})"; 
    }
}
