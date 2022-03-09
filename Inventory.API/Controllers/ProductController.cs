using Inventory.API.Data;
using Inventory.API.Interfaces;
using Inventory.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProduct _productService;

        public ProductController(IProduct productService)
        {
            _productService = productService;
        }

        // GET: api/<InventoryController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productService.GetAllProducts();   
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(Guid id)
        {
            return await _productService.GetProduct(id);    
        }

        // POST api/<InventoryController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            return await _productService.Create(product);
        }

        // PUT api/<InventoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Product product)
        {
            return await _productService.UpdateProduct(id, product);    
        }

        // DELETE api/<InventoryController>/5
        [HttpDelete("{id}")]
        public Task<IActionResult> Delete(Guid id)
        {
            return _productService.DeleteProduct(id);   
        }
    }
}
