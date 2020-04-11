using BMS.Models;
using BMS.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessageParser messageParser;

        public MessagesController(IMessageParser messageParser)
        {
            this.messageParser = messageParser;
        }

        [HttpGet]
        public IActionResult InboundMessages()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult InboundLDM(MessageInputModel  messageInputModel)
        {
            this.messageParser.ParseLDM(messageInputModel.Message);

            return this.RedirectToAction("InboundMessages");
        } 
        
        [HttpPost]
        public IActionResult InboundCPM(MessageInputModel messageInputModel)
        {
            if (this.messageParser.ParseInboundCPM(messageInputModel.Message))
            {
                return this.RedirectToAction("RegisterFuelForm", "Fuel");
            } 
            else
            {
                return this.RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult InboundUCM(MessageInputModel messageInputModel)
        {
            this.messageParser.ParseUCM(messageInputModel.Message);

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult OutboundMessages()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult OutboundCPM(MessageInputModel messageInputModel)
        {
            return this.View();
        }
    }
}
