using Microsoft.EntityFrameworkCore;
using ArtStore.Models;

namespace ArtStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // This corresponds to your Product.cs model
        public DbSet<Product> Products { get; set; }

        // If you create a User.cs model, add:
        // public DbSet<User> Users { get; set; }
    }
}
