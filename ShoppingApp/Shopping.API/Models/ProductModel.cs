using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Shopping.API.Models
{
    public class ProductModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
