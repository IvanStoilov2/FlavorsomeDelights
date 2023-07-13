using Microsoft.AspNetCore.Mvc;

namespace RecepieDelight.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
