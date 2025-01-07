using System.Collections.Generic;

namespace ArtStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }

        // Frame options
        public List<string> FrameStyles { get; set; } = new List<string> { "Classic", "Modern", "Vintage" };
        public List<int> FrameWidths { get; set; } = new List<int> { 1, 2, 3, 4 }; // Width in inches
    }
}
