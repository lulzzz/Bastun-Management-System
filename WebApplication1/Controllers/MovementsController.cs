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

        public MovementsController(IMessageParser messageParser)
        {
            this.messageParser = messageParser;
        }

        [HttpGet]
        public IActionResult Arrival()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Arrival(ArrivalMovementInputModel arrMovementInputModel)
        {
            if (this.ModelState.IsValid)
            {
                this.messageParser.ParseArrivalMovement(arrMovementInputModel);
            }
            else
            {
                return this.View(arrMovementInputModel);
            }

            return this.RedirectToAction("RegisterFuelForm", "Fuel");
        }

        [HttpGet]
        public IActionResult Departure()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Departure(DepartureMovementInputModel depMovementInputModel)
        {
            if (this.ModelState.IsValid)
            {
                this.messageParser.ParseDepartureMovement(depMovementInputModel);
            }
            else
            {
                return this.View(depMovementInputModel);
            }

            return this.RedirectToAction("Index", "Home");
        }
    }
}
