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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            TGGEncryption encryption = new TGGEncryption();
            string email, password;
            email = txtUsername.Text;
            password = encryption.HashWithSalt(txtPassword.Text);

            EmployeeService employeeService = new EmployeeService();

            Employee employee = new Employee(email, "-", password, false);
            BsonDocument employeeBsonDoc = employee.ToBsonDocument();
            List<Employee> employees = employeeService.GetEmployeesByElement(employeeBsonDoc.GetElement("email"), employeeBsonDoc.GetElement("password"));

            if(employees.Count > 0)
            {
                this.Hide();
                Dashboard newDashboard = new Dashboard(employees[0]);
                newDashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username / password !");
            }
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(txtUsername.Text);
            ResetPasswordController resetPasswordController = new ResetPasswordController(forgotPassword);
            forgotPassword.ShowDialog();
        }
    }
}
