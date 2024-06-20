using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
        new Product { Id = 1, Name = "Product1", Category = "Category1", Price = 10 },
        new Product { Id = 2, Name = "Product2", Category = "Category1", Price = 20 },
        new Product { Id = 3, Name = "Product3", Category = "Category2", Price = 30 },
        new Product { Id = 4, Name = "Product4", Category = "Category2", Price = 40 },
    };

        [HttpGet]
        public IActionResult GetProducts( string category, decimal? minPrice, decimal? maxPrice)
        {
            var products = Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category == category);
            }

            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= maxPrice.Value);
            }

            return Ok(products.ToList());
        }
    }

}
