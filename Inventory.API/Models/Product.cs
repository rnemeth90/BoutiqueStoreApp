﻿using Inventory.API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Inventory.API.Models
{
    public class Product : IProduct
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


        public Task<IActionResult> Create()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> DeleteProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            throw new NotImplementedException();
        }
    }
}
