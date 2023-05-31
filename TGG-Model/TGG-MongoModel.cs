using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace TGG_Model
{
    //ignore extra elements because they may be added programmatically
    [BsonIgnoreExtraElements(Inherited = true)]
    public abstract class TGG_MongoModel
    {
        //MongoId which is represented as "_id" in mongo db
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId MongoId { get; set; }
    }
}
