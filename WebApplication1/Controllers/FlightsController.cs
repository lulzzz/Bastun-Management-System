﻿using BMS.Models;

using BMS.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Controllers
{
    [Authorize]
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


        [HttpPost]
        public IActionResult RegisterFlight(FlightInputModel flightInputModel)
        {
            if (this.ModelState.IsValid)
            {
                this.flightService.RegisterInboundFlight(flightInputModel);
                this.flightService.RegisterOutboundFlight(flightInputModel);
                return this.RedirectToAction("RegisterAircraft");
            } 
            else
            {
                return this.View(flightInputModel);
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
                this.aircraftService.RegisterAircraft(aircraftInputModel);
                return this.RedirectToAction("Arrival", "Movements");
            }
            else
            {
                return this.View(aircraftInputModel);
            }
        }

       
    }
}
