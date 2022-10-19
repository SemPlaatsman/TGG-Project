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
    public class ResetPasswordDAO : BaseDAO
    {
        public ResetPasswordDAO() : base(TGGCollections.ValidationCodes) { }
        public void AddValidationCodes(TGGValidation validationCode)
        {
            BsonDocument bsonDoc = validationCode.ToBsonDocument();
            BsonSerializer.Deserialize<TGGValidation>(CreateOperation(new List<BsonDocument>() { bsonDoc }).First());
        }
    }
}
