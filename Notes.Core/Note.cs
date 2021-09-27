using MongoDB.Bson.Serialization.Attributes;

namespace Notes.Core
{
    public class Note
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Reference { get; set; }
        public string PersonName { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }


        public string Address1 { get; set; }  
        public string Address2 { get; set; }  
        public string City { get; set; }  
        public string County { get; set; }  
        public string Postcode { get; set; }
    }
}
