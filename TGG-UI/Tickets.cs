using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGG_Logic;
using TGG_Model;
using MongoDB.Bson;

namespace TGG_UI
{
    public partial class Tickets : Form
    {
        TicketService ticketService = new TicketService();

        public Tickets()
        {
            InitializeComponent();
        }

        private void buttonAddTicketsForm_Click(object sender, EventArgs e)
        {
            AddTickets addTicketsForm = new AddTickets();
            addTicketsForm.Show();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            List<Ticket> tickets = ticketService.GetAllTickets();
            ItemsToGridview(tickets);
        }

        private void ItemsToGridview(List<Ticket> tickets)
        {
            foreach (Ticket ticket in tickets)
            {
                gridViewTickets.Rows.Add(ticket);
            }

            gridViewTickets.DataSource = tickets;
        }
    }
}
