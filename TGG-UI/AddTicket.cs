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

namespace TGG_UI
{
    public partial class AddTicket : Form
    {
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
            CloseForm();
        }

        private void AddTickets_Load(object sender, EventArgs e)
        {
            comboBoxPrioLevel.DataSource = Enum.GetValues(typeof(TGGPriorityLevel));
        }

        private void CloseForm()
        {
            this.Close();
        }
    }
}
