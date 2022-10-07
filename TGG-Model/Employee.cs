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
    [Serializable]
    public class Employee : TGG_MongoModel
    {
        [BsonElement("employeeId"), BsonRepresentation(BsonType.Int32)]
        public int EmployeeId { get; set; }

        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public string Email { get; set; }

        [BsonElement("fullName"), BsonRepresentation(BsonType.String)]
        public string FullName { get; set; }

        [BsonElement("password"), BsonRepresentation(BsonType.String)]
        private string password;

        [BsonElement("isSDEmployee"), BsonRepresentation(BsonType.Boolean)]
        public bool IsSDEmployee { get; set; }

        public Employee(string email, string fullName, string password, bool isSDEmployee)
        {
            Email = email;
            FullName = fullName;
            this.password = password;
            IsSDEmployee = isSDEmployee;
        }
    }
}
