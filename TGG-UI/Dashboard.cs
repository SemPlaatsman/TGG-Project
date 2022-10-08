using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGG_Model;
using TGG_Logic;

namespace TGG_UI
{
    public partial class Dashboard : Form
    {
        private TicketService ticketService;

        public Dashboard()
        {
            InitializeComponent();
            ticketService = new TicketService();
            aa();
            List<Ticket> tickets = ticketService.GetAllTickets();

        }
        public void aa()
        {
            List<Ticket> tickets = ticketService.GetAllTickets();
            chart1.Series["Tickets Status"].Points[0].SetValueXY($"{tickets.Count(n => n.Status == Status.Open)}", tickets.Count(n => n.Status == Status.Open));
            chart1.Series["Tickets Status"].Points[0].LegendText = "Open";
            chart1.Series["Tickets Status"].Points.AddXY("Resolved", tickets.Count(n => n.Status == Status.Resolved));
            chart1.Series["Tickets Status"].Points.AddXY("Pending", tickets.Count(n => n.Status == Status.Pending));

        }

    }
}
