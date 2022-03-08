using Inventory.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Inventory.API.Interfaces
{
    public interface IProduct
    {
        [Key, Required]
        public Guid Id { get; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public string SKU { get; set; }

        [Required]
        public int StockCount { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Model { get; set; }

        public FormFile ProductImage { get; set; }

        Task<IEnumerable<Product>> GetAllProducts();
        
        [HttpGet]
        Task<Product> GetProduct(Guid productId);
        
        [HttpPost]
        Task<IActionResult> Create();

        [HttpPut]
        Task<IActionResult> UpdateProduct([FromBody]Product product);

        [HttpDelete]
        Task<IActionResult> DeleteProduct(Guid productId);

    }
}
