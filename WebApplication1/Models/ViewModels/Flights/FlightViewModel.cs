namespace BMS.Models.ViewModels.Flights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class FlightViewModel
    {
        public FlightViewModel(List<FlightInputModel> flights)
        {
            this.Flights = flights;
        }

        public List<FlightInputModel> Flights { get; set; }
    }
}
