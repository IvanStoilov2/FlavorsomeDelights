using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecepieDelight.Data;
using RecepieDelight.Models;
using System.Diagnostics;

namespace RecepieDelight.Controllers
{
    public class HomeController : Controller
    {

        private readonly RecepieDelightContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(RecepieDelightContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var random = new Random((int)DateTime.Now.ToOADate());

            var recepies = _context.Recepie.Include("Category").ToList();
            var result = recepies[random.Next(recepies.Count)];
            
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}