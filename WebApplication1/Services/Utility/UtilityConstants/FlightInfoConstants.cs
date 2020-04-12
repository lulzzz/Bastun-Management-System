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

        public const string IsLDMLoadInfoValid = @"(?<station>\-[A-Z]{3})\.(?<M>[0-9]{1,3})\/(?<female>[0-9]{1,3})\/(?<children>[0-9]{1,3})\/(?<infants>[0-9]{1,3})\.(?<ttlWghtInCpt>[T]\.[0-9]{1,20})\.(?<wghtByCompartment>[0-9\/\.]+)";

        public const string IsLDMSummaryInfoValid = @"(?<PAX>[A-Z]{3}\/[0-9]{1,3})\.(?<bags>[B]\/[0-9]{1,3})\/\.(?<cargo>[A-Z]{1}\/[0-9]+|[A-Z]{1}\/[A-Z]{3})";
    }
}
