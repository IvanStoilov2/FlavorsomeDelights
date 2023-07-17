using Microsoft.AspNetCore.Mvc;

namespace RecepieDelight.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
