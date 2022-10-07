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
        }
        public void aa()
        {
            List<Ticket> tickets = ticketService.GetAllTickets();


        }

    }
}
