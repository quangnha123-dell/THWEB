using Microsoft.AspNetCore.Mvc;

namespace TH.Areas.Adim.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
