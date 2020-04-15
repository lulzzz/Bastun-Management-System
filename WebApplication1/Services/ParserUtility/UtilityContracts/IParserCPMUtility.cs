namespace BMS.Services.ParserUtility.UtilityContracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public interface IParserCPMUtility
    {
        Regex FlightInfo { get; set; }

        Regex LoadDistribution { get; set; }

        Regex LoadSummary { get; set; }

        int GetContainerCount(string[] splitMessageContent);
    }
}
