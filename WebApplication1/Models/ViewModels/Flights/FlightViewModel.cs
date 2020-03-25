using System.Collections.Generic;

namespace BMS.Models.ViewModels.Flights
{
    public class FlightViewModel
    {
        public FlightViewModel(IEnumerable<FlightInputModel> flightInputModels)
        {
            this.Flights = flightInputModels;
        }

        public IEnumerable<FlightInputModel> Flights { get; set; }
    }
}
