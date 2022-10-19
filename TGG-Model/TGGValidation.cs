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
            [BsonElement("dateAdded"), BsonRepresentation(BsonType.DateTime)]
            private DateTime dateAdded { get; set; }

        public TGGValidation(string email)
            {
                Email = email;
                ValidationCode = RandomString(10);
                dateAdded = DateTime.Now;
            }
        public TGGValidation(string email, string validationCode)
        {
            Email = email;
            ValidationCode = validationCode;
        }
        public static string RandomString(int length)
        {
            Random r = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[r.Next(s.Length)]).ToArray());
        }
    }
}
