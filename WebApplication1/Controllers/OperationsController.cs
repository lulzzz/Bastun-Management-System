using BMS.Models;
using BMS.Models.LoadingInstructionInputModels;
using BMS.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class OperationsController : Controller
    {
        private readonly IFlightService flightService;
        private readonly IAircraftService aircraftService;
        private readonly ILoadControlService loadControlService;

        public OperationsController(IFlightService flightService, IAircraftService aircraftService, ILoadControlService loadControlService)
        {
            this.flightService = flightService;
            this.aircraftService = aircraftService;
            this.loadControlService = loadControlService;
        }


        [HttpGet]
        public IActionResult Loadsheet()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult DefaultLoadingInstruction()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult DetermineCorrectLoadingInstruction(string flightNumber)
        {
            var flight = this.flightService.GetOutboundFlightByFlightNumber(flightNumber);
            string type = this.aircraftService.IsAircraftOfACertainType(flight);
            string correctLoadingInstruction = this.loadControlService.GetCorrectLoadingInstruction(type);

            if (correctLoadingInstruction == null)
            {
                this.ModelState.AddModelError(string.Empty, "No valid loading instruction report found!");
            }

            return this.View(correctLoadingInstruction);
        }

        [HttpPost]
        public IActionResult FileBulkLoadingInstruction(BulkLoadingInstructionInputModel loadingInstructionInputModel)
        {

            return this.Ok();
        }

        [HttpPost]
        public IActionResult File788ContainerLoadingInstruction(_788LoadingInstructionInputModel loadingInstructionInputModel)
        {
            return this.Ok();
        }

        [HttpPost]
        public IActionResult File763ContainerLoadingInstruction(_763LoadingInstructionInputModel loadingInstructionInputModel)
        {
            return this.Ok();
        }

        [HttpGet]
        public IActionResult PAXManifest()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult DepartureControl()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Depart()
        {

            return this.Ok();
        }
    }
}
