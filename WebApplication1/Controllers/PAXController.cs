using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class PAXController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Remove()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Display()
        {
            return this.View();
        }
    }
}
