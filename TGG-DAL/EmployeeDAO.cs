using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using TGG_Model;

namespace TGG_DAL
{
    public class EmployeeDAO : BaseDAO
    {
        public EmployeeDAO() : base(TGGCollections.Employees) { }

        public List<Employee> ReadAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            List<BsonDocument> bsonDocs = ReadOperation(Builders<BsonDocument>.Filter.Empty);

            foreach (BsonDocument bsonDoc in bsonDocs)
            {
                Employee employee = new Employee();
                employee.Id = (int)bsonDoc["Id"];
                employee.Email = (string)bsonDoc["email"];
                employee.FullName = (string)bsonDoc["fullName"];
                employee.IsSDEmployee = (bool)bsonDoc["isSDEmployee"];
            }

            return employees;
        }
    }
}
