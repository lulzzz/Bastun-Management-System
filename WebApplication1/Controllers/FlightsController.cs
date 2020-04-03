using BMS.Models;
using BMS.Models.ViewModels.Flights;
using BMS.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Controllers
{
    public class FlightsController : Controller
    {
        private readonly IFlightService flightService;

        public FlightsController(IFlightService flightService)
        {
            this.flightService = flightService;
        }

        [HttpGet]
        public IActionResult RegisterFlight()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult DisplayDaily()
        {
            var allFlightsFromDb = this.flightService.GetAllFlights();
            var allFlightsViewModel = new FlightViewModel(allFlightsFromDb);

            return this.View(allFlightsViewModel);
        }

        [HttpPost]
        public IActionResult RegisterFlight(FlightInputModel flightInputModel)
        {
            if (this.ModelState.IsValid)
            {
                this.flightService.RegisterFlight(flightInputModel);
                return this.RedirectToAction("RegisterAircraft", new { flightNumber = flightInputModel.FlightNumber});
            } 
            else
            {
                var listOfErrors = this.ModelState.Select(x => x.Value.Errors)
                    .Where(v => v.Count > 0)
                    .ToList();

                return this.View(listOfErrors);
            }

           
        }

        [HttpGet]
        public IActionResult RegisterAircraft(string flightNumber)
        {
            return this.View();
        }

       
    }
}
