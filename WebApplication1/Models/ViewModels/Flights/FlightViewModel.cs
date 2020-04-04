namespace BMS.Models.ViewModels.Flights
{
    using BMS.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class FlightViewModel
    {
        public FlightViewModel(ICollection<Flight> listOfFlights)
        {
            this.Flights = listOfFlights;
        }

        public ICollection<Flight> Flights { get; set; }
    }
}
