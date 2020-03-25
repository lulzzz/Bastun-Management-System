using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BMS.Models;
using BMS.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFlightService flightService;

        public HomeController(ILogger<HomeController> logger, IFlightService flightService)
        {
            _logger = logger;
            this.flightService = flightService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public void RegisterFlight(FlightInputModel flightInputModel)
        {
            //TODO: Use automapper to create flight, fix date formats to utc
            //create service for get all flights from db 
            //create view model to pass to all flights to daily using new format
            this.flightService.RegisterFlight(flightInputModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
