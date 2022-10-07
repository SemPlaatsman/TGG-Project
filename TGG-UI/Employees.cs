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
    public partial class Employees : Form
    {
        private EmployeeService employeeService;

        private Timer timer;

        public Employees()
        {
            InitializeComponent();

            employeeService = new EmployeeService();

            this.timer = new Timer();
            this.timer.Tick += EmployeesTickEvent;
            this.timer.Interval = 30000;
            this.timer.Start();

            Test();
        }

        public void Test()
        {
            List<Employee> employees = employeeService.GetAllEmployees();
            MessageBox.Show("SUCCASS!");
            //employeeService.UpdateEmployeeByElement(new BsonElement("employeeId", 2), new BsonElement("employeeId", 2), new BsonElement("isSDEmployee", false));
            //employeeService.DeleteEmployeeByElement(new BsonElement("employeeId", 4));
            MessageBox.Show("SUCCESS");
        }

        private void EmployeesTickEvent(object sender, EventArgs e)
        {

        }
    }
}
