﻿
using Inventory.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
