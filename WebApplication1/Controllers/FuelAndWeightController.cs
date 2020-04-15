using BMS.Models;
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
    public class FuelAndWeightController : Controller
    {
        private readonly IFuelAndWeightService fuelService;

        public FuelAndWeightController(IFuelAndWeightService fuelService)
        {
            this.fuelService = fuelService;
        }


        [HttpGet]
        public IActionResult FuelForm()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult RegisterFuelForm(FuelFormInputModel fuelInputModel)
        {
            if (this.ModelState.IsValid)
            {
                this.fuelService.AddFuelForm(fuelInputModel);
            }
            else
            {
                return this.View();
            }

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult RegisterWeightForm()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult RegisterWeightForm(WeightFormInputModel weightInputModel)
        {
            return this.View(weightInputModel);
        }
    }
}
