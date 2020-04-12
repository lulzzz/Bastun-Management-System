namespace BMS.Models.ViewModels.Flights
{
    using BMS.Models.ViewModels.Flights.InboundFlights;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class InboundFlightsViewModel
    {
        public InboundFlightsViewModel()
        {
            this.InboundFlights = new List<InboundFlightDetailsModel>();
        }

        public List<InboundFlightDetailsModel> InboundFlights { get; set; }
    }
}
