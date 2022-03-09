using Inventory.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.API.Interfaces
{
    public interface IProduct
    {
        Task<IEnumerable<Product>> GetAllProducts();
        
        [HttpGet]
        Task<Product> GetProduct(Guid productId);
        
        [HttpPost]
        Task<IActionResult> Create([FromBody]Product product);

        [HttpPut]
        Task<IActionResult> UpdateProduct(Guid id, [FromBody]Product product);

        [HttpDelete]
        Task<IActionResult> DeleteProduct(Guid productId);

    }
}
