using BMS.Models;
using BMS.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    [Authorize]
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
            if (this.ModelState.IsValid)
            {
                this.messageParser.ParseInboundLDM(messageInputModel.Message);
                return this.RedirectToAction("InboundMessages");
            } 
            else
            {
                return this.RedirectToAction("Index", "Home");
            }
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

        [HttpGet]
        public IActionResult OutboundMessages()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult OutboundCPM(MessageInputModel messageInputModel)
        {
            if (this.ModelState.IsValid)
            {
                if (this.messageParser.ParseOutboundCPM(messageInputModel.Message))
                {
                    return this.RedirectToAction("Index", "Home");
                } 
                else
                {
                    return this.RedirectToAction("OutboundMessages");
                }
            }

            return this.RedirectToAction("OutboundMessages", messageInputModel);
        }


        [HttpPost]
        public IActionResult OutboundLDM(MessageInputModel messageInputModel)
        {
            if (this.ModelState.IsValid)
            {
                if (this.messageParser.ParseOutboundLDM(messageInputModel.Message))
                {
                    return this.RedirectToAction("Index", "Home");
                }
                else
                {
                    return this.RedirectToAction("OutboundMessages");
                }
            }

            return this.RedirectToAction("OutboundMessages", messageInputModel);
        }
    }
}
