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

    }
}
