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
        //employee ID
        [BsonElement("employeeId"), BsonRepresentation(BsonType.Int32)]
        public int EmployeeId { get; set; }

        //email
        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public string Email { get; set; }

        //full Name
        [BsonElement("fullName"), BsonRepresentation(BsonType.String)]
        public string FullName { get; set; }

        //password
        [BsonElement("password"), BsonRepresentation(BsonType.String)]
        public string Password { get; set; }

        //bool to check if an employee is an Service Desk Employee
        [BsonElement("isSDEmployee"), BsonRepresentation(BsonType.Boolean)]
        public bool IsSDEmployee { get; set; }

        public Employee(string email, string fullName, string password, bool isSDEmployee)
        {
            Email = email;
            FullName = fullName;
            Password = password;
            IsSDEmployee = isSDEmployee;
        }
        public Employee(string email)
        {
            Email = email;
        }
    }
}
