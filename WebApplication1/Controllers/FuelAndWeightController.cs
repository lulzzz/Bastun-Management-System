using BMS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class FuelAndWeightController : Controller
    {

        [HttpGet]
        public IActionResult FuelForm()
        {
            return this.View();
        }

        [HttpPost]
        public void RegisterFuelForm(FuelFormInputModel fuelInputModel)
        {

        }

        [HttpGet]
        public IActionResult RegisterWeightForm()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult RegisterWeightForm(WeightInputModel weightInputModel)
        {
            return this.View(weightInputModel);
        }
    }
}
