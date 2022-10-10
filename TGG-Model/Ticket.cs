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
    public class Ticket : TGG_MongoModel
    {

        [BsonElement("ticketId"), BsonRepresentation(BsonType.Int32)]
        public int TicketID { get; set; }

        [BsonElement("employeeId"), BsonRepresentation(BsonType.Int32)]
        public int EmployeeID { get; set; }

        [BsonElement("title"), BsonRepresentation(BsonType.String)]
        public string Title { get; set; }

        [BsonElement("description"), BsonRepresentation(BsonType.String)]
        public string Description { get; set; }

        [BsonElement("timeAdded"), BsonRepresentation(BsonType.DateTime)]
        public DateTime TimeAdded { get; set; }

        [BsonElement("timeDeadline"), BsonRepresentation(BsonType.DateTime)]
        public DateTime TimeDeadline { get; set; }

        [BsonElement("priorityLevel"), BsonRepresentation(BsonType.Int32)]
        public TGGPriorityLevel PriorityLevel { get; set; }

        [BsonElement("branch"), BsonRepresentation(BsonType.String)]
        public string Branch { get; set; }

        [BsonElement("status"), BsonRepresentation(BsonType.Int32)]
        public TGGStatus Status { get; set; }
    }
}
