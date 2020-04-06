using BMS.Models.MessagesInputModels.InboundMessagesInputModels;
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
        public IActionResult InboundLDM(InboundMessageInputModel messageInputModel)
        {
            this.messageParser.ParseLDM(messageInputModel.LDMMessage);

            return this.RedirectToAction("InboundMessages");
        } 
        
        [HttpPost]
        public IActionResult InboundCPM(InboundMessageInputModel messageInputModel)
        {
            this.messageParser.ParseCPM(messageInputModel.CPMMessage);

            return this.RedirectToAction("maika ti");
        }

        [HttpPost]
        public IActionResult InboundUCM(InboundMessageInputModel messageInputModel)
        {
            this.messageParser.ParseUCM(messageInputModel.UCMMessage);

            return this.RedirectToAction("test");
        }

        [HttpGet]
        public IActionResult OutboundMessages()
        {
            return this.View();
        }
    }
}
