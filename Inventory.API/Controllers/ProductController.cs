using Inventory.API.Data;
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
        private AppDbContext _dbContext;

        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<InventoryController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbContext.Products.ToListAsync());
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _dbContext.Products.FindAsync(id));
        }

        // POST api/<InventoryController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            return Ok(await _dbContext.AddAsync(product));
        }

        // PUT api/<InventoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Product product)
        {
            var p = _dbContext.Products.Find(id);
            if (p == null)
                return BadRequest();
            else
                p.Name = product.Name;
                p.Manufacturer = product.Manufacturer;
                p.Model = product.Model;
                await _dbContext.SaveChangesAsync();
                return Ok(StatusCodes.Status200OK);
        }

        // DELETE api/<InventoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            Product p = await _dbContext.Products.FindAsync(id);
            if(p == null)
                return NotFound();
            else
                _dbContext.Remove(p);
                _dbContext.SaveChanges(true);
                return Ok($"Product {p.Id} removed");
        }
    }
}
