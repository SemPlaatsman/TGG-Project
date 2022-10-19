using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGG_Logic;
using TGG_Model;

namespace TGG_UI
{
    public partial class ForgotPassword : Form
    {
        private EmployeeService employeeService;
        private ResetPasswordService resetPasswordService;
        private List<Employee> employees;
        public ForgotPassword(string emailAddress)
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            resetPasswordService = new ResetPasswordService();
        }

        private void buttonNextEmailEntered_Click(object sender, EventArgs e)
        {
            panelEnterEmail.Hide();
            employees = employeeService.GetEmployeesByElement(new Employee(textBoxEmail.Text).ToBsonDocument().GetElement("email"));
            if (employees.Count != 0)
            {
                var client = new SmtpClient("smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("aee2f8f4701483", "119bbc2e9eaa33"),
                    EnableSsl = true
                };
                TGGValidation validationForUser = new TGGValidation(textBoxEmail.Text);
                client.Send("Support@TGG.com", textBoxEmail.Text, "Reset Password", $"Your confirmation code is: {validationForUser.ValidationCode}." +
                    $"\nThis code is only valid for 10 minutes.");
                resetPasswordService.InsertValidationCode(validationForUser);

            }
            labelExtraInformation.Text = "Verification mail has been sent!\nThis verification code is only valid for 10 minutes.";


        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack2EmailEnter_Click(object sender, EventArgs e)
        {
            panelEnterEmail.Show();
            labelExtraInformation.Text = string.Empty;
        }

        private void buttonConfirmCode_Click(object sender, EventArgs e)
        {

            if (resetPasswordService.CheckValidationByElement(new TGGValidation(textBoxEmail.Text, textBoxCode.Text)))
            {
                panelEnterCode.Hide();
            }
            else
            {
                labelExtraInformation.Text = "Wrong verification code!";
            }

        }

        private void buttonConfirmNewPassword_Click(object sender, EventArgs e)
        {
            if(CheckForValidPassword())
            {
                resetPasswordService.UpdateEmployeePassword(employees[0]);
                labelExtraInformation.Text = "success!";
            }
        }
        private bool CheckForValidPassword()
        {
            try
            {
                if (textBoxEnterPass.Text.Length < 8)
                {
                    throw new Exception("minimum password size is 8 characters");
                }
                if (textBoxEnterPass.Text != textBoxConfirmPass.Text)
                {
                    throw new Exception("Passwords do not match!");
                }
            }
            catch (Exception ex)
            {
                labelExtraInformation.Text = ex.Message;
                return false;
            }
            return true;
        }
    }
}
