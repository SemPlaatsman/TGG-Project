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

        //insert documents into main db
        protected List<BsonDocument> CreateOperation(List<BsonDocument> bsonDocs)
        {
            currentCollection.InsertMany(bsonDocs);
            return bsonDocs;
        }

        //read documents from main db
        protected List<BsonDocument> ReadOperation(FilterDefinition<BsonDocument> filter, SortDefinition<BsonDocument> sort = null)
        {
            //if sort is not filled then don't use it
            if (sort == null)
                return currentCollection.Find(filter).ToList();
            return currentCollection.Find(filter).Sort(sort).ToList();
        }

        //update documents in main db
        protected UpdateResult UpdateOperation(FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
        {
            return currentCollection.UpdateMany(filter, update);
        }

        //delete documents in main db
        protected DeleteResult DeleteOperation(FilterDefinition<BsonDocument> filter)
        {
            return currentCollection.DeleteMany(filter);
        }

        //archive documents into archive db
        protected List<BsonDocument> ArchiveOperation(List<BsonDocument> bsonDocs)
        {
            //switch current collection to archive db collection
            currentCollection = mongoArchiveDB.GetCollection<BsonDocument>(currentCollection.CollectionNamespace.CollectionName);
            //insert documents
            bsonDocs = CreateOperation(bsonDocs);
            //switch current collection back to main db collection
            currentCollection = mongoMainDB.GetCollection<BsonDocument>(currentCollection.CollectionNamespace.CollectionName);
            return bsonDocs;
        }
    }
}
