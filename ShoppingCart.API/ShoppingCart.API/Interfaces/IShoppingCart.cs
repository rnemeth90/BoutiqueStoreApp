using Microsoft.AspNetCore.Mvc;
using ShoppingCart.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCart.API.Interfaces
{
    public interface IShoppingCart
    {
        List<Product> products { get; }
        
        [HttpGet]
        Task<ShoppingCart.API.Models.ShoppingCart> Get();
        
        [HttpPost]
        Task<ShoppingCart.API.Models.ShoppingCart> Create();
        
        [HttpPut]
        Task<IActionResult> Update(ShoppingCart.API.Models.ShoppingCart shoppingCart);
        
        [HttpDelete]
        Task<IActionResult> Delete(ShoppingCart.API.Models.ShoppingCart shoppingCart);
    }
}
