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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            //List<Employee> employees = employeeService.GetAllEmployees();
            //MessageBox.Show($"{employees.FirstOrDefault().employeeId}");
            //employeeService.UpdateEmployeeByElement(new BsonElement("employeeId", 2), new BsonElement("employeeId", 2), new BsonElement("isSDEmployee", false));
            //employeeService.DeleteEmployeeByElement(new BsonElement("employeeId", 4));
            MessageBox.Show("SUCCESS");
        }
    }
}
