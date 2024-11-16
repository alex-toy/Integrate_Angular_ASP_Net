using HelloWorldApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet("GetAll")]
    public IEnumerable<Product> GetAll()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 19.99m },
            new Product { Id = 2, Name = "Product 2", Price = 29.99m },
            new Product { Id = 3, Name = "Product 3", Price = 39.99m }
        };
    }
}
