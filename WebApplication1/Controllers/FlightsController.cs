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
        private readonly IAircraftService aircraftService;

        public FlightsController(IFlightService flightService, IAircraftService aircraftService)
        {
            this.flightService = flightService;
            this.aircraftService = aircraftService;
        }

        [HttpGet]
        public IActionResult RegisterFlight()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult DisplayDaily()
        {
            var flight = this.flightService.GetFlightByFlightNumber("BY-2130");

            var flights = this.flightService.GetAllFlights();
            var dailyFlightsViewModel = new FlightViewModel(flights);

            return this.View(dailyFlightsViewModel);
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
        public IActionResult RegisterAircraft()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult RegisterAircraft(AircraftInputModel aircraftInputModel)
        {
            if (this.ModelState.IsValid)
            {
                var flightByFlightNumber = this.flightService.GetFlightByFlightNumber(aircraftInputModel.FlightNumber);

                if (flightByFlightNumber != null)
                {
                    this.aircraftService.RegisterAircraft(aircraftInputModel, flightByFlightNumber);
                }
                else
                {
                    return this.View();
                }
            

                return this.RedirectToAction("Arrival", "Movements", new { flightNumber = aircraftInputModel.FlightNumber });
            }
            else
            {
                var listOfErrors = this.ModelState.Select(x => x.Value.Errors)
                   .Where(v => v.Count > 0)
                   .ToList();

                return this.View(listOfErrors);
            }
        }

       
    }
}
