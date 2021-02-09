using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping.API.Data
{
    public static class ProductContext
    {
        private static readonly string[] Brands = new[]
        {
            "MSI", "Asus", "Gigabyte", "Gainward", "Sapphire", "EVGA"
        };

        private static readonly string[] ModelNames = new[]
        {
            "GeForce GTX 1030", "GeForce GTX 1650", "GeForce RTX 2060", "GeForce RTX 2070"
        };

        public static IReadOnlyList<ProductModel> ProductList
        {
            get
            {
                var random = new Random();

                return Enumerable.Range(1, 5).Select(index => new ProductModel
                {
                    Id = index,
                    Brand = Brands[random.Next(Brands.Length)],
                    ModelName = ModelNames[random.Next(ModelNames.Length)],
                    Category = "Graphics Cards",
                    Price = random.Next(88, 289)
                })
                .ToArray();
            }
        }
    }
}
