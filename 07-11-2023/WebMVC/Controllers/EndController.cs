using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class EndController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
