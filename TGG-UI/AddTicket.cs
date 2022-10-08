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

namespace TGG_UI
{
    public partial class AddTicket : Form
    {
        TicketService ticketService = new TicketService();

        public AddTicket()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            Ticket ticket = new Ticket();

            ticket.TimeAdded = dateTimePickerTimeReported.Value;
            ticket.TimeDeadline = dateTimePickerDeadline.Value;
            ticket.EmployeeID = int.Parse(textBoxEmployeeId.Text);
            ticket.Title = textBoxTitle.Text;
            ticket.PriorityLevel = (TGGPriorityLevel)comboBoxPrioLevel.SelectedIndex;
            ticket.Description = richTextBoxDescription.Text;

            ticketService.AddTicket(ticket);

            CloseForm();
        }

        private void AddTickets_Load(object sender, EventArgs e)
        {
            comboBoxPrioLevel.DataSource = Enum.GetValues(typeof(TGGPriorityLevel));
            //comboBoxStatus.DataSource = Enum.GetValues(typeof(TGGPriorityLevel));
        }

        private void CloseForm()
        {
            this.Close();
        }
    }
}
