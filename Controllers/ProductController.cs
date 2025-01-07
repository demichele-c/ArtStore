using Microsoft.AspNetCore.Mvc;
using ArtStore.Models;

namespace ArtStore.Controllers
{
    public class ProductController : Controller
    {
        // Dummy product data
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Starry Night", Price = 299.99m, ImagePath = "/images/starry-night.jpg" },
            new Product { Id = 2, Name = "Mona Lisa", Price = 199.99m, ImagePath = "/images/mona-lisa.jpg" }
        };

        // Displays product listing
        public IActionResult Index()
        {
            return View(_products);
        }

        // Displays details of a specific product
        public IActionResult Details(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            return View(product);
        }
    }
}
