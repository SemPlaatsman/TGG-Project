using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TGG_DAL
{
    public abstract class BaseDAO
    {
        private MongoClient dbClient;
        private IMongoDatabase database;

        public BaseDAO()
        {
            dbClient = new MongoClient();
        }
    }
}
