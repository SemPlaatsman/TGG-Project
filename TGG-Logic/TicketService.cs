using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_DAL;
using TGG_Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TGG_Logic
{
    public class TicketService
    {
        private TicketDAO ticketDAO;

        public TicketService()
        {
            ticketDAO = new TicketDAO();
        }

        public List<Ticket> GetAllTickets()
        {
            return ticketDAO.GetAllTickets();
        }

        public Ticket AddTicket(Ticket ticket)
        {
            return ticketDAO.AddTicket(ticket);
        }

        public List<Ticket> GetTicketByElement(BsonElement filterElement)
        {
            return ticketDAO.GetTicketByElement(filterElement);
        }

        public List<Ticket> GetTicketBelowAddedDate(BsonElement filterElement)
        {
            return ticketDAO.GetTicketBelowAddedDate(filterElement);
        }

        public List<UpdateResult> UpdateTicketByElement(BsonElement filterElement, BsonElement updateElement, params BsonElement[] extraUpdateElements)
        {
            return ticketDAO.UpdateTicketByElement(filterElement, updateElement, extraUpdateElements);
        }

        public DeleteResult DeleteTicketByCollection(ICollection<Ticket> filterCollection)
        {
            return ticketDAO.DeleteTicketByCollection(filterCollection);
        }

        public DeleteResult DeleteTicketByElement(BsonElement filterElement)
        {
            return ticketDAO.DeleteTicketByElement(filterElement);
        }

        public List<Ticket> Archive(List<Ticket> tickets)
        {
            return ticketDAO.Archive(tickets);
        }
    }
}
