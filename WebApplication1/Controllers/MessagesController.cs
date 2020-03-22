using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    public class MessagesController : Controller
    {
        [HttpGet]
        public IActionResult InboundMessages()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult OutboundMessages()
        {
            return this.View();
        }
    }
}
