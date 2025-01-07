using Microsoft.AspNetCore.Mvc;
using ArtStore.Models;

namespace ArtStore.Controllers
{
    public class CheckoutController : Controller
    {
        // Handles the preview of selected frame options
        [HttpPost]
        public IActionResult Preview(int productId, string frameStyle, int frameWidth)
        {
            var product = new Product
            {
                Id = productId,
                Name = "Starry Night", // Replace with real data from the database if needed
                Price = 299.99m,
                ImagePath = "/images/starry-night.jpg"
            };

            ViewData["FrameStyle"] = frameStyle;
            ViewData["FrameWidth"] = frameWidth;

            return View(product);
        }

        // Confirms the order and processes the checkout
        [HttpPost]
        public IActionResult Confirm(int productId, string frameStyle, int frameWidth)
        {
            return Content($"Order confirmed for product {productId} with {frameStyle} frame and {frameWidth}-inch width.");
        }
    }
}
