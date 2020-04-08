using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class FuelController : Controller
    {

        [HttpGet]
        public IActionResult FuelForm()
        {
            return this.View();
        }

        [HttpPost]
        public void RegisterFuelForm()
        {

        }
    }
}
