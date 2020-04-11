using BMS.Models;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class FuelAndWeightController : Controller
    {
        public FuelAndWeightController()
        {

        }


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
