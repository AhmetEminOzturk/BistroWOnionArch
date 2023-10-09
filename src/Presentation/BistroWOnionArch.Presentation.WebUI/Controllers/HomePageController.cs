using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
