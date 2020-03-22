using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class WeightController : Controller
    {

        [HttpGet]
        public IActionResult WeightAndBalanceForm()
        {
            return this.View();
        }

        [HttpPost]
        public void RegisterWeightAndBalanceForm()
        {

        }
    }
}
