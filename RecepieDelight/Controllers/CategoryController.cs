using Microsoft.AspNetCore.Mvc;
using RecepieDelight.Data;
using RecepieDelight.Models;

namespace RecepieDelight.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RecepieDelightContext _context;


        public CategoryController(ILogger<HomeController> logger, RecepieDelightContext context)
        {
            _logger = logger;
            _context = context;
        }
        // Other action methods...

        public IActionResult CreateCategories()
        {
            // Create a list of Category entities and populate their properties
            var categories = new List<Category>
            {
                new Category { Name = "Category 1" },
                new Category { Name = "Category 2" },
                new Category { Name = "Category 3" }
            };

            // Add the list of Category entities to the DbSet
            _context.Category.AddRange(categories);
            _context.SaveChanges();

            // Optionally, return a view or redirect to another action
            return RedirectToAction("Index", "Home");
        }

        private readonly RecepieDelightContext _contexts;

        public CategoryController(RecepieDelightContext context)
        {
            _contexts = context;
        }

        public IActionResult Index(int categoryId)
        {
            var result = _context.Category.Where(x => x.Id == categoryId).FirstOrDefault();
            ViewData["Title"] = result == null ? string.Empty : result.Name;

            return View(result);
        }

        public string GetName(int categoryId)
        {
            var result = _context.Category.Where(x => x.Id == categoryId).FirstOrDefault();

            return result == null ? string.Empty : result.Name;
        }
    }

}

