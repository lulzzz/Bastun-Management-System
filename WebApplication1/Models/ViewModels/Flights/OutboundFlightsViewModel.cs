namespace BMS.Models.ViewModels.Flights
{
    using BMS.Models.ViewModels.Flights.OutboundFlights;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class OutboundFlightsViewModel
    {
        public OutboundFlightsViewModel()
        {
            this.OutboundFlights = new List<OutboundFlightDetailsModel>();
        }

        public List<OutboundFlightDetailsModel> OutboundFlights { get; set; }
    }
}
