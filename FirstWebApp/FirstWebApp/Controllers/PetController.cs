using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
