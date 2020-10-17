using Microsoft.AspNetCore.Mvc;

namespace Rating.Controllers
{
    public class MainPageController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}