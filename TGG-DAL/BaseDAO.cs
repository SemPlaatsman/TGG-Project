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
        private readonly IMongoDatabase mongoMainDB;
        private readonly IMongoDatabase mongoArchiveDB;
        private IMongoCollection<BsonDocument> currentCollection;


        protected BaseDAO(TGGCollections collection)
        {
            mongoClient = new MongoClient(ConfigurationManager.ConnectionStrings["MongoConnection"].ConnectionString);
            mongoMainDB = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoMainDBName"]);
            mongoArchiveDB = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoArchiveDBName"]);
            currentCollection = mongoMainDB.GetCollection<BsonDocument>(collection.ToString());
        }

        protected BsonDocument CreateOperation(BsonDocument bsonDoc)
        {
            currentCollection.InsertOne(bsonDoc);
            return bsonDoc;
        }

        protected List<BsonDocument> ReadOperation(FilterDefinition<BsonDocument> filter, SortDefinition<BsonDocument> sort = null)
        {
            if (sort == null)
                return currentCollection.Find(filter).ToList();
            return currentCollection.Find(filter).Sort(sort).ToList();
        }

        protected UpdateResult UpdateOperation(FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
        {
            return currentCollection.UpdateMany(filter, update);
        }

        protected DeleteResult DeleteOperation(FilterDefinition<BsonDocument> filter)
        {
            return currentCollection.DeleteMany(filter);
        }

        protected void ArchiveOperation(List<BsonDocument> bsonDocs)
        {
            currentCollection = mongoArchiveDB.GetCollection<BsonDocument>(currentCollection.CollectionNamespace.CollectionName);
            currentCollection.InsertMany(bsonDocs);
            currentCollection = mongoMainDB.GetCollection<BsonDocument>(currentCollection.CollectionNamespace.CollectionName);
        }
    }
}
