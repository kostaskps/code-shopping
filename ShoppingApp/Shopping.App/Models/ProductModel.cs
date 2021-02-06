using System.ComponentModel.DataAnnotations;

namespace Shopping.App.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
