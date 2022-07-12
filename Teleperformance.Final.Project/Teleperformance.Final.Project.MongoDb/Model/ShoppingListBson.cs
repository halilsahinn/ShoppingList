using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Teleperformance.Final.Project.Domain.Product;

namespace Teleperformance.Final.Project.MongoDb.Model
{
    public class ShoppingListBson
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
       
        public List<ProductEntity> Products { get; set; }
        public string CategoryId { get; set; }
        public string UserId { get; set; }

         
        public bool IsComplete { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? CompletedDate { get; set; }


    }
}
