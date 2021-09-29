using MongoDB.Bson.Serialization.Attributes;
using System;

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
        public double Amount { get; set; }
        public double AmountRepaid { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime FineIssuedDate { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime TransactionDate { get; set; }
        public string TxRef { get; set; }  
        public string Email { get; set; }  
        public string Address1 { get; set; }  
        public string Address2 { get; set; }  
        public string City { get; set; }  
        public string County { get; set; }  
        public string Postcode { get; set; }
    }
}
