using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class PAXController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        
        [HttpGet]
        public IActionResult OffloadEdit()
        {
            return this.View();
        }
      
    }
}
