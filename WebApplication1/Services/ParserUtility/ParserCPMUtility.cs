namespace BMS.Services.ParserUtility
{
    using BMS.Services.ParserUtility.UtilityContracts;
    using BMS.Services.Utility.UtilityConstants;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class ParserCPMUtility : IParserCPMUtility
    {
        public Regex FlightInfo { get; set; } = new Regex(FlightInfoConstants.IsLDMFlightInfoValid);

        public Regex LoadDistribution { get; set; } = new Regex(FlightInfoConstants.IsLDMLoadInfoValid);

        public Regex LoadSummary { get; set; } = new Regex(FlightInfoConstants.IsLDMLoadSummaryInfoValid);

        public int GetContainerCount(string[] splitCpmData)
        {
            int containerCount = 0;

            for (int i = 2; i < splitCpmData.Length - 1; i++)
            {
                containerCount++;
            }

            return containerCount;
        }
    }
}
