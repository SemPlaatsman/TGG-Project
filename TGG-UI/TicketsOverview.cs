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
        private TicketService ticketService = new TicketService();
        private List<Ticket> tickets;
        private Timer timer;
        private Employee employee;

        public TicketsOverview(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void buttonAddTicketsForm_Click(object sender, EventArgs e)
        {
            timer.Stop();
            AddTicket addTicketsForm = new AddTicket();
            addTicketsForm.Show();
            ItemsToGridview(tickets);
            timer.Start();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
           
            LoadTickets();
            ItemsToGridview(tickets);

            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            LoadTickets();
            ItemsToGridview(tickets);
        }

        private void buttonSortPriorityLevel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            List<Ticket> sortPriorityLevel = tickets.OrderBy(p => p.PriorityLevel).ToList();
            tickets = sortPriorityLevel;
            ItemsToGridview(tickets);
        }

        private void ItemsToGridview(List<Ticket> tickets)
        {
            gridViewTickets.DataSource = tickets;

            this.gridViewTickets.Columns["TimeAdded"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            this.gridViewTickets.Columns["TimeDeadline"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            this.gridViewTickets.Columns["MongoId"].Visible = false;
        }

        private void LoadTickets()
        {
            tickets = ticketService.GetAllTickets();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

        }
    }
}
