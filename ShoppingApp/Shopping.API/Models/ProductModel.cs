using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Shopping.API.Models
{
    public class ProductModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
