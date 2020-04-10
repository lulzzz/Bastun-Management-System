﻿using Microsoft.AspNetCore.Mvc;
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
