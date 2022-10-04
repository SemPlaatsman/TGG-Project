using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TGG_DAL
{
    public abstract class BaseDAO
    {
        private MongoClient mongoClient;
        private IMongoDatabase mongoDatabase;

        public BaseDAO()
        {
            mongoClient = new MongoClient(ConfigurationManager.ConnectionStrings["MongoConnection"].ConnectionString);
            mongoDatabase = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
        }
    }
}
