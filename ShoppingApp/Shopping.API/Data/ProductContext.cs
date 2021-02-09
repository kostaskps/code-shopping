using Shopping.API.Models;
using System.Collections.Generic;

namespace Shopping.API.Data
{
    public static class ProductContext
    {
        public static IReadOnlyList<ProductModel> ProductList = new List<ProductModel>()
        {
            new ProductModel {Id = 1, Brand = "GeForce GTX 1030", ModelName = "MSI GeForce GTX 1030 2GB", Category = "Graphics Cards", Price = 89.50M},
            new ProductModel {Id = 2, Brand = "GeForce GTX 1650", ModelName = "ASUS GeForce GTX 1650 4GB", Category = "Graphics Cards", Price = 132.48M},
            new ProductModel {Id = 2, Brand = "GeForce RTX 2060", ModelName = "Gigabyte GeForce RTX 2060 6GB", Category = "Graphics Cards", Price = 402.67M},
            new ProductModel {Id = 2, Brand = "GeForce RTX 2070", ModelName = "Gainward GeForce GTX 2070 8GB, PCI Express x16 4.0, HDMI: 1, DisplayPort: 3", Category = "Graphics Cards", Price = 510.65M}
        };
    }
}
