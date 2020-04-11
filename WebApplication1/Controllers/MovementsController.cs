using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.Models.MovementsInputModels;
using BMS.Services.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class MovementsController : Controller
    {
        private readonly IMessageParser messageParser;
        private readonly IFlightService flightService;

        public MovementsController(IMessageParser messageParser,IFlightService flightService)
        {
            this.messageParser = messageParser;
            this.flightService = flightService;
        }

        [HttpGet]
        public IActionResult Arrival()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Arrival(MovementInputModel movementInput)
        {

            if (this.ModelState.IsValid)
            {
                if (this.messageParser.ParseArrivalMovement(movementInput.Movement))
                {
                    return this.Redirect("/Messages/InboundMessages");
                }
                else
                {
                    return this.View(movementInput);
                }
            }

            return this.View(movementInput);
        }

        [HttpGet]
        public IActionResult Departure()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Departure(MovementInputModel movementInput)
        {
            if (this.ModelState.IsValid)
            {
                if (this.messageParser.ParseDepartureMovement(movementInput.Movement))
                {
                    return this.Redirect("/Messages/OutboundMessages");
                } 
                else
                {
                    return this.View(movementInput);
                }

            }

            return this.View(movementInput);
        }
    }
}
