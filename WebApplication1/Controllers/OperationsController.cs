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

        [HttpGet]
        public IActionResult Loadsheet()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult LoadingInstruction()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult FileLoadingInstruction()
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
