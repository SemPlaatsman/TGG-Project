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
    public partial class TicketsOverview : Form
    {
        TicketService ticketService = new TicketService();

        public TicketsOverview()
        {
            InitializeComponent();
        }

        private void buttonAddTicketsForm_Click(object sender, EventArgs e)
        {
            AddTicket addTicketsForm = new AddTicket();
            addTicketsForm.Show();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            List<Ticket> tickets = ticketService.GetAllTickets();
            ItemsToGridview(tickets);
        }

        private void ItemsToGridview(List<Ticket> tickets)
        {
            gridViewTickets.DataSource = tickets;
            this.gridViewTickets.Columns["TimeAdded"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            this.gridViewTickets.Columns["TimeDeadline"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }
    }
}
