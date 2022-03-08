using Microsoft.AspNetCore.Mvc;
using ShoppingCart.API.Data;
using ShoppingCart.API.Interfaces;
using ShoppingCart.API.Models;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCart.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        internal IShoppingCart _shoppingCart;

        public ShoppingCartController(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;   
        }


        // call methods from service for routes
        public async Task<IShoppingCart> Get()
        { 
            return await _shoppingCart.Get();
        }


    }
}
