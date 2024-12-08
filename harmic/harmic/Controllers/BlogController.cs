using Microsoft.AspNetCore.Mvc;

namespace harmic.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
