using Merchandise.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Merchandise.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
