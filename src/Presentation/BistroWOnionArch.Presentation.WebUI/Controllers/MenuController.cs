using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
