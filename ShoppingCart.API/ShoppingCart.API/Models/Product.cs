using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.API.Models
{
    public class Product
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int ProductId { get; }

    }
}
