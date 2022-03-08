using Microsoft.AspNetCore.Mvc;
using ShoppingCart.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.API.Models
{
    public class ShoppingCart : IShoppingCart
    {
        [Key, Required]
        public int Id { get; set; }
        public List<Product> products { get; set; }


        public Task<ShoppingCart> Add()
        {
            throw new System.NotImplementedException();
        }

        public Task<ShoppingCart> Create()
        {
            throw new System.NotImplementedException();
        }

        public Task<IActionResult> Delete(ShoppingCart shoppingCart)
        {
            throw new System.NotImplementedException();
        }

        public Task<ShoppingCart> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<IActionResult> Update(ShoppingCart shoppingCart)
        {
            throw new System.NotImplementedException();
        }
    }
}
