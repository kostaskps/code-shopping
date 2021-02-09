using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping.API.Data
{
    public class ProductContext
    {
        public ProductContext(IConfiguration configuration)
        {
            var mongoClient = new MongoClient(configuration["MongoDBSettings:ConnectionString"]);
            var database = mongoClient.GetDatabase(configuration["MongoDBSettings:Database"]);
            
            Products = database.GetCollection<ProductModel>(configuration["MongoDBSettings:Collection"]);
            SeedData(Products);
        }

        public IMongoCollection<ProductModel> Products { get; }

        private void SeedData(IMongoCollection<ProductModel> productCollection)
        {
            var containsProducts = productCollection.Find(p => true).Any();
            if (!containsProducts)
            {
                productCollection.InsertManyAsync(ProvidePreconfiguredProducts());
            }
        }

        private IEnumerable<ProductModel> ProvidePreconfiguredProducts()
        {
            string[] Brands = new[] { "MSI", "Asus", "Gigabyte", "Gainward", "Sapphire", "EVGA" };
            string[] ModelNames = new[] { "GeForce GTX 1030", "GeForce GTX 1650", "GeForce RTX 2060", "GeForce RTX 2070" };

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
