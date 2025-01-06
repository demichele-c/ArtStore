using Microsoft.AspNetCore.Mvc;
using ArtStore.Data;
using ArtStore.Models;
using System.Linq;

namespace ArtStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // Additional CRUD actions (Create, Edit, Delete) can be added here
    }
}
