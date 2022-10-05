using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace TGG_Model
{
    [Serializable, BsonIgnoreExtraElements]
    public class Employee
    {
        //[BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        //private ObjectId mongoId { get; set; }

        [BsonElement("employeeId"), BsonRepresentation(BsonType.Int32)]
        public int employeeId { get; set; }

        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public string Email { get; set; }

        [BsonElement("fullName"), BsonRepresentation(BsonType.String)]
        public string FullName { get; set; }

        [BsonElement("isSDEmployee"), BsonRepresentation(BsonType.Boolean)]
        public bool IsSDEmployee { get; set; }
    }
}
