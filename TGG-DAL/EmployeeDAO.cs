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

        //add employees
        public List<Employee> AddEmployee(List<Employee> employees)
        {
            List<BsonDocument> bsonDocs = new List<BsonDocument>();
            //remove employeeId from the bsonDocs so that mongo will auto increment that value
            foreach (Employee employee in employees)
            {
                BsonDocument bsonDoc = employee.ToBsonDocument();
                bsonDoc.Remove("employeeId");
                bsonDocs.Add(bsonDoc);
            }
            return ReadEmployees(CreateOperation(bsonDocs));
        }

        //get employees
        public List<Employee> GetAllEmployees()
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Empty;
            return ReadEmployees(ReadOperation(filter));
        }

        //get employees by element
        public List<Employee> GetEmployeesByElement(BsonElement filterElement, params BsonElement[] extraFilterElements)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterElement.Name, filterElement.Value);
            //add extra elements to filter by
            foreach (BsonElement element in extraFilterElements)
            {
                filter &= Builders<BsonDocument>.Filter.Eq(element.Name, element.Value);
            }
            return ReadEmployees(ReadOperation(filter));
        }

        //update employees
        public List<UpdateResult> UpdateEmployeeByElement(BsonElement filterElement, BsonElement requiredUpdateElement, params BsonElement[] extraUpdateElements)
        {
            List<UpdateResult> updateResults = new List<UpdateResult>();
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterElement.Name, filterElement.Value);

            //collect all update elements into one list
            List<BsonElement> allUpdateElements = new List<BsonElement>() { requiredUpdateElement };
            allUpdateElements.AddRange(extraUpdateElements);
            foreach (BsonElement bsonElement in allUpdateElements.ToList())
            {
                //if the filter element is equal to the current update element,
                //set that update element to the last index of the update elements list
                //because if the filter element isn't changed last then the reference won't be accurate anymore
                if (bsonElement.Name == filterElement.Name)
                {
                    allUpdateElements[allUpdateElements.IndexOf(bsonElement)] = allUpdateElements.Last();
                    allUpdateElements[allUpdateElements.Count - 1] = bsonElement;
                }
            }

            //update everything
            foreach (BsonElement updateElement in allUpdateElements)
            {
                UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set(updateElement.Name, updateElement.Value);
                updateResults.Add(UpdateOperation(filter, update));
            }

            return updateResults;
        }

        //delete employees
        public DeleteResult DeleteEmployeeByElement(BsonElement filterElement)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterElement.Name, filterElement.Value);
            return DeleteOperation(filter);
        }

        //convert bsonDocs to employees list
        private List<Employee> ReadEmployees(List<BsonDocument> bsonDocs)
        {
            List<Employee> employees = new List<Employee>();

            foreach (BsonDocument bsonDoc in bsonDocs)
                employees.Add(BsonSerializer.Deserialize<Employee>(bsonDoc));

            return employees;
        }
    }
}
