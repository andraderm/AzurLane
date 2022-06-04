using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AzurLaneApi.Domain.Entities
{
    public class BaseEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Removed { get; set; }

        public BaseEntity()
        {
            Id = string.Empty;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Removed = false;
        }

        public void PrepareToInsert()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Removed = false;
        }

        public void PrepareToUpdate()
        {
            UpdatedAt = DateTime.Now;
        }
    }
}
