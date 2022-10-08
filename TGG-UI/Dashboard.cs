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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Status = TGG_Model.Status;

namespace TGG_UI
{
    public partial class Dashboard : Form
    {
        private TicketService ticketService;
        private List<Ticket> tickets;
        public Dashboard()
        {
            InitializeComponent();
            ticketService = new TicketService();
            tickets = ticketService.GetAllTickets();
            FillCharts();
            UpdateTopBar(tickets);

        }
        public void FillCharts()
        {
            ////chartHighUrgency.Series["Tickets Status"].Points.AddXY("Resolved", tickets.Count(n => n.Status == Status.Resolved));
            ////chartHighUrgency.Series["Tickets Status"].Points[1].LegendText = "Resolved";
            ////chartHighUrgency.Series["Tickets Status"].Points.AddXY("Pending", tickets.Count(n => n.Status == Status.Pending));
            ////chartHighUrgency.Series["Tickets Status"].Points[1].LegendText = "Pending";
            for(int i = Enum.GetValues(typeof(TGGPriorityLevel)).Length - 1; i >= 0; i--)
            {
                FillChart((TGGPriorityLevel)i);
            }
        }
        public void FillChart(TGGPriorityLevel priorityLevel)
        {
            int countOfPendingTickets = tickets.Count(n => n.PriorityLevel == priorityLevel && n.Status == Status.Pending);
            int countOfOpenTickets = tickets.Count(n => n.PriorityLevel == priorityLevel && n.Status == Status.Open);
            int countOfOverdueTickets = tickets.Count(n => n.PriorityLevel == priorityLevel && n.TimeDeadline <= DateTime.Today);
            ((Chart)(flowLayoutPanelCharts.Controls[(int)priorityLevel])).Series[0].Points[0].SetValueXY(countOfPendingTickets.ToString(), countOfPendingTickets);
            ((Chart)(flowLayoutPanelCharts.Controls[(int)priorityLevel])).Series[0].Points[1].SetValueXY(countOfOpenTickets.ToString(), countOfOpenTickets);
            ((Chart)(flowLayoutPanelCharts.Controls[(int)priorityLevel])).Series[0].Points[2].SetValueXY(countOfOverdueTickets.ToString(), countOfOverdueTickets);
            CheckIfEmptyChart((Chart)(flowLayoutPanelCharts.Controls[(int)priorityLevel]));
        }
        public void CheckIfEmptyChart(Chart chart)
        {
            int count = 0;
            foreach(DataPoint dataPoints in chart.Series[0].Points)
            {
                if (dataPoints.YValues[0] == 0)
                {
                    count++;
                }
            }
            if(count == chart.Series[0].Points.Count())
            {
                chart.BackImage = "Properties.Resources.noun_ticket_3263895.png";
            }
        }
        public void UpdateTopBar(List<Ticket> tickets)
        {
            labelAmountOverdue.Text = tickets.Count(n => n.TimeDeadline <= DateTime.Today).ToString();
            labelAmountPendingHU.Text = tickets.Count(
                n => n.PriorityLevel == TGGPriorityLevel.High && n.Status ==Status.Pending).ToString();
            labelAmountOpenHU.Text = tickets.Count(
                n => n.PriorityLevel == TGGPriorityLevel.High && n.Status == Status.Open).ToString();   
            labelAmountOpenPendingNU.Text = tickets.Count(
                n => n.PriorityLevel <= TGGPriorityLevel.High && (n.Status == Status.Open|| n.Status == Status.Pending)).ToString();
            
        }

    }
}
