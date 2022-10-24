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

        private Employee employee;

        //max seconds to add employee so that the application doesn't get stuck waiting for a response
        //(5 seconds is enough for max 50 requests to the database)
        const int maxSecondsToAddEmployee = 5;
        public AddEmployee(EmployeeService employeeService, Employee employee)
        {
            try
            {
                InitializeComponent();

                this.employeeService = employeeService;

                this.employee = employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while trying to load the add employee form!\nPlease contact the application administrator!", "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TGGErrorLogger.WriteLogToFile(ex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //validate data
                if (!ValidateData())
                    return;
                //parse the values in the input field to an Employee object and insert it into the mongo database
                Employee addedEmployee = employeeService.AddEmployee(new Employee(txtEmail.Text, txtFullName.Text, txtPassword.Text, Convert.ToBoolean(cBoxEmployeeType.SelectedIndex)));
                //get the added employee from the database
                addedEmployee = employeeService.GetEmployeesByElement(addedEmployee.ToBsonDocument().GetElement("_id")).First();
                for (int i = 0; addedEmployee.EmployeeId == 0; i++)
                {
                    //as long as the added employee still has the default employee id it means it isn't present in the mongo database yet,
                    //sleep for 100 milliseconds and then make another request
                    Thread.Sleep(100);
                    addedEmployee = employeeService.GetEmployeesByElement(addedEmployee.ToBsonDocument().GetElement("_id")).First();
                    if (i >= (maxSecondsToAddEmployee * 10))
                    {
                        //throw an exception if the wait time has been exceeded
                        throw new Exception($"max wait time of {maxSecondsToAddEmployee} seconds to add an employee was exceeded!");
                    }
                }
                //display added employee to the user then hide the AddEmployee dialog
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
            //validate every field
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
            //check if entered email is a valid email address
            if (!new Regex(@"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,3}").Match(txtEmail.Text).Success)
            {
                //focus on incorrect input field and set an error with the errorProvider
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "Please use a valid email address!");
                return false;
            }
            //reset error message from error provider
            errorProvider.SetError(txtEmail, null);
            return true;
        }

        private bool ValidateTextbox(TextBox txtBox)
        {
            if (txtBox.Text == String.Empty)
            {
                //focus on incorrect input field and set an error with the errorProvider
                txtBox.Focus();
                errorProvider.SetError(txtBox, $"Please enter your {txtBox.Tag}!");
                return false;
            }
            //reset error message from error provider
            errorProvider.SetError(txtBox, null);
            return true;
        }

        private bool ValidateComboBox(ComboBox cBox)
        {
            if (cBox.SelectedIndex == -1)
            {
                //focus on incorrect input field and set an error with the errorProvider
                cBox.Focus();
                errorProvider.SetError(cBox, $"Please choose an {cBox.Tag}!");
                return false;
            }
            //reset error message from error provider
            errorProvider.SetError(cBox, null);
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //hide password
        private void btnPasswordHide_Click(object sender, EventArgs e)
        {
            btnPasswordShow.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
        }

        //show password
        private void btnPasswordShow_Click(object sender, EventArgs e)
        {
            btnPasswordHide.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void AddEmployee_Paint(object sender, PaintEventArgs e)
        {
            //paint a border around the AddEmployee dialog
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(232, 231, 213), 5), new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }
}
