using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
