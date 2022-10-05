﻿using System;
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

        public void UpdateEmployeeByElement(BsonElement filterElement, BsonElement updateElement, params BsonElement[] extraUpdateElements)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterElement.Name, filterElement.Value);
            UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set(updateElement.Name, updateElement.Value);
            UpdateOperation(filter, update);

            foreach (BsonElement extraUpdateElement in extraUpdateElements)
            {
                update = Builders<BsonDocument>.Update.Set(extraUpdateElement.Name, extraUpdateElement.Value);
                UpdateOperation(filter, update);
            }
        }

        public void DeleteEmployeeByElement(BsonElement filterElement)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterElement.Name, filterElement.Value);
            DeleteOperation(filter);
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
