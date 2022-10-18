﻿using System;
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
            NavbarChange();
        }

        private void buttonAddTicketsForm_Click(object sender, EventArgs e)
        {
            timer.Stop();
            AddTicket addTicketsForm = new AddTicket(employee);
            addTicketsForm.Show();
            ItemsToGridview(tickets);
            timer.Start();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
           
            LoadTickets();
            ItemsToGridview(tickets);

            timer = new Timer();
            timer.Interval = 3000;
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
            try
            {
                gridViewTickets.DataSource = tickets;

                this.gridViewTickets.Columns["TimeAdded"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                this.gridViewTickets.Columns["TimeDeadline"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                this.gridViewTickets.Columns["MongoId"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while loading the tickets list, please try and contact admin");
            }
        }

        private void LoadTickets()
        {
            tickets = ticketService.GetAllTickets();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            try
            {
                //all tickets older than 2 years will be moved to the archive database and deleted from the main database
                List<Ticket> ticketsToArchive = ticketService.GetTicketBelowAddedDate(new Ticket() { TimeAdded = DateTime.Now.AddYears(-2) }.ToBsonDocument().GetElement("timeAdded"));
                if (ticketsToArchive.Count <= 0)
                    throw new TGGException("There are no tickets older than 2 years to be moved to the archive database!");
                MessageBox.Show($"{ticketService.DeleteTicketByCollection(ticketService.Archive(ticketsToArchive)).DeletedCount.ToString()} tickets were moved to the archive database!",
                    "Archive result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (TGGException tggex)
            {
                MessageBox.Show(tggex.Message, "Something unexpected happened...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! Please contact your application administrator", "An error occurred...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TGGErrorLogger.WriteLogToFile(ex);
            }
        }

        private void NavbarChange()
        {
            if (!employee.IsSDEmployee)
            {
                navigationBarPanel.ColumnStyles[2].Width = 0;
            }
        }

        private void dashBoardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard(employee).ShowDialog();
            this.Close();
        }

        private void employeeOverviewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employees(employee).ShowDialog();
            this.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
