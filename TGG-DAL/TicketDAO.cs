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

        public List<UpdateResult> UpdateTicketByElement(BsonElement filterElement, BsonElement requiredUpdateElement, params BsonElement[] extraUpdateElements)
        {
            List<UpdateResult> updateResults = new List<UpdateResult>();
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterElement.Name, filterElement.Value);

            List<BsonElement> allUpdateElements = new List<BsonElement>() { requiredUpdateElement };
            allUpdateElements.AddRange(extraUpdateElements);
            foreach (BsonElement bsonElement in allUpdateElements.ToList())
            {
                if (bsonElement.Name == filterElement.Name)
                {
                    allUpdateElements[allUpdateElements.IndexOf(bsonElement)] = allUpdateElements.Last();
                    allUpdateElements[allUpdateElements.Count - 1] = bsonElement;
                }
            }

            foreach (BsonElement updateElement in allUpdateElements)
            {
                UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set(updateElement.Name, updateElement.Value);
                updateResults.Add(UpdateOperation(filter, update));
            }

            return updateResults;
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
