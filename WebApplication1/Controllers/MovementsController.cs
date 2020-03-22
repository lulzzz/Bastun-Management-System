using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.MovementsInputModels;

namespace WebApplication1.Controllers
{
    public class MovementsController : Controller
    {
        public MovementsController()
        {

        }

        [HttpGet]
        public IActionResult Arrival()
        {
            return this.View();
        }


        [HttpPost]
        public void Arrival(ArrivalMovementInputModel arrMovementInputModel)
        {
            
        }

        [HttpGet]
        public IActionResult Departure()
        {
            return this.View();
        }

        [HttpPost]
        public void Departure(DepartureMovementInputModel depMovementInputModel)
        {
            
        }
    }
}
