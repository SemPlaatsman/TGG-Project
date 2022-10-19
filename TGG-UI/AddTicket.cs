using MongoDB.Bson;
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
        private TicketService ticketService = new TicketService();
        private EmployeeService employeeService = new EmployeeService();
        private List<Employee> employees;
        private Employee employee;

        public AddTicket(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();

            try
            {
                if (String.IsNullOrEmpty(comboBoxEmployeeId.Text) || String.IsNullOrEmpty(textBoxTitle.Text))
                {
                    MessageBox.Show("Please enter a employee id and title");
                    return;
                }

                ticket.EmployeeID = int.Parse(comboBoxEmployeeId.Text);
                ticket.Title = textBoxTitle.Text;
                ticket.Description = richTextBoxDescription.Text;
                ticket.TimeAdded = dateTimePickerTimeReported.Value;
                ticket.TimeDeadline = dateTimePickerDeadline.Value;
                ticket.PriorityLevel = (TGGPriorityLevel)Enum.Parse(typeof(TGGPriorityLevel), comboBoxPrioLevel.SelectedIndex.ToString());
                ticket.TGGStatus = (TGGStatus)Enum.Parse(typeof(TGGStatus), comboBoxPrioLevel.SelectedIndex.ToString());

                ticketService.AddTicket(ticket);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong with adding a ticket, please try and contact admin");
            }

            CloseForm();
        }

        private void AddTickets_Load(object sender, EventArgs e)
        {
            ValidateIsNotSDEmployee();
            comboBoxPrioLevel.DataSource = Enum.GetValues(typeof(TGGPriorityLevel));
            comboBoxStatus.DataSource = Enum.GetValues(typeof(TGGStatus));
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void ValidateIsNotSDEmployee()
        {
            if (!employee.IsSDEmployee)
            {
                comboBoxEmployeeId.Items.Add(employee.EmployeeId);
            } else {
                EmployeesToComboBox();
            }
        }

        private void EmployeesToComboBox()
        {
            employees = employeeService.GetAllEmployees();
            foreach (Employee employee in employees)
            {
                comboBoxEmployeeId.Items.Add(employee.EmployeeId);
            }
        }
    }
}
