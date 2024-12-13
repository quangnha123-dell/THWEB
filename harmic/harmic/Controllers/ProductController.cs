using Microsoft.AspNetCore.Mvc;

namespace harmic.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
