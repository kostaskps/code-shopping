using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.API.Data;
using Shopping.API.Models;
using System.Collections.Generic;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Brands = new[]
        {
            "MSI", "Asus", "Gigabyte", "Gainward", "Sapphire", "EVGA"
        };

        private static readonly string[] ModelNames = new[]
        {
            "GeForce GTX 1030", "GeForce GTX 1650", "GeForce RTX 2060", "GeForce RTX 2070"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public ProductController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            return ProductContext.ProductList;
        }
    }
}
