using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGG_Model
{
    public class TGGValidation : TGG_MongoModel
    {
 

            [BsonElement("email"), BsonRepresentation(BsonType.String)]
            public string Email { get; set; }

            [BsonElement("validationCode"), BsonRepresentation(BsonType.String)]
            public string ValidationCode { get; set; }

            public TGGValidation(string email, string validationCode)
            {
                Email = email;
                ValidationCode = validationCode;
            }
    }
}
