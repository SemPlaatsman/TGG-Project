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

        public List<Employee> GetAllEmployees()
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Empty;

            return ReadEmployees(ReadOperation(filter));
        }

        private List<Employee> ReadEmployees(List<BsonDocument> bsonDocs)
        {
            List<Employee> employees = new List<Employee>();

            foreach (BsonDocument bsonDoc in bsonDocs)
                employees.Add(ReadEmployee(bsonDoc));

            return employees;
        }

        private Employee ReadEmployee(BsonDocument bsonDoc)
        {
            Employee employee = new Employee();
            employee.Id = (int)bsonDoc["employeeId"];
            employee.Email = (string)bsonDoc["email"];
            employee.FullName = (string)bsonDoc["fullName"];
            employee.IsSDEmployee = (bool)bsonDoc["isSDEmployee"];
            return employee;
        }
    }
}
