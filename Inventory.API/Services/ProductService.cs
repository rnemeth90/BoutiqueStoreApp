using Inventory.API.Data;
using Inventory.API.Interfaces;
using Inventory.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Inventory.API.Services
{
    public class ProductService : ControllerBase, IProduct
    {
        private IAppDbContext _dbContext;


        public ProductService(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]Product product)
        {
            if (!_dbContext.Products.Any(p => p.Id == product.Id))
                await _dbContext.Products.AddAsync(product);
                await _dbContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        public async Task<IActionResult> DeleteProduct(Guid productId)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
                return Ok(StatusCodes.Status404NotFound);
            else
                _dbContext.Products.Remove(product);
                await _dbContext.SaveChangesAsync();
            return Ok(StatusCodes.Status200OK);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(Guid productId)
        {
            if (!_dbContext.Products.Any(p => p.Id == productId))
                return null; // this is weird. we should not do this..
            return await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == productId);   
        }

        public async Task<IActionResult> UpdateProduct(Guid id, [FromBody] Product product)
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
    }
}
