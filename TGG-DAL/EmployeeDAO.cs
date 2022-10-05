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

        public void AddEmployee(Employee employee)
        {
            CreateOperation(employee.ToBsonDocument());
        }

        public List<Employee> GetAllEmployees()
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Empty;
            return ReadEmployees(ReadOperation(filter));
        }

        public List<UpdateResult> UpdateEmployeeByElement(BsonElement filterElement, BsonElement requiredUpdateElement, params BsonElement[] extraUpdateElements)
        {
            List<UpdateResult> updateResults = new List<UpdateResult>();
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterElement.Name, filterElement.Value);

            List<BsonElement> allUpdateElements = new List<BsonElement>() { requiredUpdateElement };
            allUpdateElements.AddRange(extraUpdateElements);
            foreach (BsonElement bsonElement in allUpdateElements.ToList())
            {
                if (bsonElement.Name == "employeeId")
                {
                    allUpdateElements[allUpdateElements.IndexOf(bsonElement)] = allUpdateElements.Last();
                    allUpdateElements[allUpdateElements.Count - 1] = bsonElement;
                }
            }

            foreach (BsonElement updateElement in allUpdateElements)
            {
                UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set(updateElement.Name, updateElement.Value);
                updateResults.Add(UpdateOperation(filter, update));
            }

            return updateResults;
        }

        public DeleteResult DeleteEmployeeByElement(BsonElement filterElement)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterElement.Name, filterElement.Value);
            return DeleteOperation(filter);
        }

        private List<Employee> ReadEmployees(List<BsonDocument> bsonDocs)
        {
            List<Employee> employees = new List<Employee>();

            foreach (BsonDocument bsonDoc in bsonDocs)
                employees.Add(BsonSerializer.Deserialize<Employee>(bsonDoc));

            return employees;
        }
    }
}
