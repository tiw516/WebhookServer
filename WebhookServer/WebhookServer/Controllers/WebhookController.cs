using Microsoft.AspNetCore.Mvc;

namespace WebhookServer.Controllers
{
    public class WebhookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
