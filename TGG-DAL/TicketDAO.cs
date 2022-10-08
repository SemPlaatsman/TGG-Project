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
    public class TicketDAO : BaseDAO
    {
        public TicketDAO() : base(TGGCollections.Tickets) { }

        public List<Ticket> GetAllTickets()
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Empty;
            return ReadTickets(ReadOperation(filter));
        }

        public List<Ticket> ReadTickets(List<BsonDocument> bsonDocuments)
        {
            List<Ticket> tickets = new List<Ticket>();

            foreach (BsonDocument bsons in bsonDocuments)
            {
                tickets.Add(BsonSerializer.Deserialize<Ticket>(bsons));
            }

            return tickets;
        }

        public void AddTicket(Ticket ticket)
        {
            CreateOperation(ticket.ToBsonDocument());
        }

        public void Archive(List<Ticket> tickets)
        {
            List<BsonDocument> bsonDocs = new List<BsonDocument>();
            foreach (Ticket ticket in tickets)
                bsonDocs.Add(ticket.ToBsonDocument());
            ArchiveOperation(bsonDocs);
        }
    }
}
