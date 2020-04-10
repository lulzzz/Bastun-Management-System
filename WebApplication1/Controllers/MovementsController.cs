using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.Models.MovementsInputModels;
using BMS.Services.Contracts;

namespace WebApplication1.Controllers
{
    public class MovementsController : Controller
    {
        private readonly IMessageParser messageParser;
        private readonly IAircraftService aircraftService;

        public MovementsController(IMessageParser messageParser, IAircraftService aircraftService)
        {
            this.messageParser = messageParser;
            this.aircraftService = aircraftService;
        }

        [HttpGet]
        public IActionResult Arrival()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Arrival(MovementInputModel movementInput)
        {
            var ac = this.aircraftService.GetAicraftByRegistration("DAZAPX");
            ac.Cabin.ZoneAlphaCapacity -= 30;
            ac.BaggageHold.CompartmentOneTotalWeight += 500;

            var hold = ac.BaggageHold;
            if (this.messageParser.ParseArrivalMovement(movementInput.ArrivalMovement))
            {
                return this.Redirect("/Home/Index");
            } 
            else 
            {
                return this.View(movementInput);
            }
        }

        [HttpGet]
        public IActionResult Departure()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Departure(MovementInputModel movementInput)
        {
            this.messageParser.ParseDepartureMovement(movementInput.DepartureMovement);

            return this.RedirectToAction("Index", "Home");
        }
    }
}
