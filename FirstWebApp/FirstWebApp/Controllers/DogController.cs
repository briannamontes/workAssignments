using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class DogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bark()
        {
            return View();
        }
    }
}
