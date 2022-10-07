using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using TGG_Model;

namespace TGG_DAL
{
    public abstract class BaseDAO
    {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase mongoDatabase;
        private readonly IMongoCollection<BsonDocument> currentCollection;

        public BaseDAO(TGGCollections collection)
        {
            mongoClient = new MongoClient(ConfigurationManager.ConnectionStrings["MongoConnection"].ConnectionString);
            mongoDatabase = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
            currentCollection = mongoDatabase.GetCollection<BsonDocument>(collection.ToString());
        }

        public BsonDocument CreateOperation(BsonDocument bsonDoc)
        {
            bsonDoc.Remove("employeeId");
            currentCollection.InsertOne(bsonDoc);
            return bsonDoc;
        }

        public List<BsonDocument> ReadOperation(FilterDefinition<BsonDocument> filter, SortDefinition<BsonDocument> sort = null)
        {
            if (sort == null)
                return currentCollection.Find(filter).ToList();
            return currentCollection.Find(filter).Sort(sort).ToList();
        }

        public UpdateResult UpdateOperation(FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
        {
            return currentCollection.UpdateMany(filter, update);
        }

        public DeleteResult DeleteOperation(FilterDefinition<BsonDocument> filter)
        {
            return currentCollection.DeleteMany(filter);
        }
    }
}
