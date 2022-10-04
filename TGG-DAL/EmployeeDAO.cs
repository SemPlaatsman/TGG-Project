using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
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

            List<BsonDocument> bsonDoc = ReadOperation(
                Builders<BsonDocument>.Filter.Empty);

            return employees;
        }
    }
}
