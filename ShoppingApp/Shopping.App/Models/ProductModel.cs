using System.ComponentModel.DataAnnotations;

namespace Shopping.App.Models
{
    public class ProductModel
    {
        public string Id { get; set; }

        public string Brand { get; set; }
        public string ModelName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
