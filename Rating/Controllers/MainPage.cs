using Microsoft.AspNetCore.Mvc;

namespace Rating.Controllers
{
    public class MainPage : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}