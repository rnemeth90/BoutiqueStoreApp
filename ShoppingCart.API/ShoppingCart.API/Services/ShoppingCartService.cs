using Microsoft.AspNetCore.Mvc;
using ShoppingCart.API.Data;
using ShoppingCart.API.Interfaces;
using ShoppingCart.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCart.API.Services
{
    public class ShoppingCartService : IShoppingCart
    {
        public ApiDbContext _dbContext;

        public ShoppingCartService()
        {
            _dbContext = new ApiDbContext();
        }

        public List<Product> products => throw new System.NotImplementedException();

        public Task<Models.ShoppingCart> Create()
        {
            throw new System.NotImplementedException();
        }

        public Task<IActionResult> Delete(Models.ShoppingCart shoppingCart)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ShoppingCart.API.Models.ShoppingCart> Get()
        {
            return new ();
        }

        public Task<IActionResult> Update(Models.ShoppingCart shoppingCart)
        {
            throw new System.NotImplementedException();
        }
    }
}
