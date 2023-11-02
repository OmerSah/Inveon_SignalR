using InveonSignalR.Web.Hubs;
using InveonSignalR.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace InveonSignalR.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YoneticiController : Controller
    {
        private readonly IHubContext<MessageHub> _messageHub;

        public YoneticiController(IHubContext<MessageHub> messageHub)
        {
            _messageHub = messageHub;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Git()
        {
            return View();
        }

        public IActionResult AdminLogout()
        {
            return SignOut("Cookies", "oidc");
        }

        [Route("[Controller]/Message")]
        [HttpPost]
        public IActionResult Order([FromBody] Message message)
        {
            //same bussines rules
            _messageHub.Clients.All.SendAsync("lastMessage", message);

            return Accepted();
        }
    }
}
