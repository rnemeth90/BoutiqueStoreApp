using Microsoft.EntityFrameworkCore;
using ShoppingCart.API.Models;
using ShoppingCart.API.Interfaces;

namespace ShoppingCart.API.Data
{
    public class ApiDbContext : DbContext
    {
        internal DbSet<IShoppingCart> _shoppingCart { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = ShoppingCartApiDb;");
        }
    }
}
