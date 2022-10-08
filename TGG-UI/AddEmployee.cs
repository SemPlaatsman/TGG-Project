using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using TGG_Logic;
using TGG_Model;
using MongoDB.Bson;
using System.Text.RegularExpressions;

namespace TGG_UI
{
    public partial class AddEmployee : Form
    {
        private EmployeeService employeeService;
        const int maxSecondsToAddEmployee = 3;
        public AddEmployee(EmployeeService employeeService)
        {
            InitializeComponent();

            this.employeeService = employeeService;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData())
                    return;
                Employee addedEmployee = employeeService.AddEmployee(new Employee(txtEmail.Text, txtFullName.Text, txtPassword.Text, Convert.ToBoolean(cBoxEmployeeType.SelectedIndex)));
                addedEmployee = employeeService.GetEmployeesByElement(addedEmployee.ToBsonDocument().GetElement("_id")).First();
                for (int i = 0; addedEmployee.EmployeeId == 0; i++)
                {
                    Thread.Sleep(100);
                    addedEmployee = employeeService.GetEmployeesByElement(addedEmployee.ToBsonDocument().GetElement("_id")).First();
                    if (i >= (maxSecondsToAddEmployee * 10))
                    {
                        throw new Exception($"max wait time of {maxSecondsToAddEmployee} seconds to add an employee was exceeded!");
                    }
                }
                MessageBox.Show($"{addedEmployee.FullName} was successfully added as a {(addedEmployee.IsSDEmployee ? "service desk employee" : "regular employee")} " +
                    $"with the email address '{addedEmployee.Email}' and employee ID '{addedEmployee.EmployeeId}'", 
                    "Successfully added an employee...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while trying to create an employee!\nPlease contact the application administrator!", "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TGGErrorLogger.WriteLogToFile(ex);
            }
        }

        private bool ValidateData()
        {
            bool result = true;
            if (!ValidateComboBox(cBoxEmployeeType))
                result = false;
            if (!ValidateTextbox(txtPassword))
                result = false;
            if (!ValidateTextbox(txtFullName))
                result = false;
            if (!ValidateTextbox(txtEmail) || !ValidateEmail(txtEmail.Text))
                result = false;
            return result;
        }

        private bool ValidateEmail(string email)
        {
            if (!new Regex(@"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,3}").Match(txtEmail.Text).Success)
            {
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "Please use a valid email address!");
                return false;
            }
            errorProvider.SetError(txtEmail, null);
            return true;
        }

        private bool ValidateTextbox(TextBox txtBox)
        {
            if (txtBox.Text == String.Empty)
            {
                txtBox.Focus();
                errorProvider.SetError(txtBox, $"Please enter your {txtBox.Tag.ToString()}!");
                return false;
            }
            errorProvider.SetError(txtBox, null);
            return true;
        }

        private bool ValidateComboBox(ComboBox cBox)
        {
            if (cBox.SelectedIndex == -1)
            {
                cBox.Focus();
                errorProvider.SetError(cBox, $"Please choose an {cBox.Tag.ToString()}!");
                return false;
            }
            errorProvider.SetError(cBox, null);
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPasswordHide_Click(object sender, EventArgs e)
        {
            btnPasswordShow.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnPasswordShow_Click(object sender, EventArgs e)
        {
            btnPasswordHide.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
