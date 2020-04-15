namespace BMS.Data.DTO.FlightDTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class InboundFlightDTO
    {
        public string FlightNumber { get; set; }

        public string Origin { get; set; }

        public DateTime STA { get; set; }

    }
}
