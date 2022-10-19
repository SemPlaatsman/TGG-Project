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
        private TGGEncryption encryptionService;
        public ForgotPassword(string emailAddress)
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            resetPasswordService = new ResetPasswordService();
            encryptionService = new TGGEncryption();
        }

        private void buttonNextEmailEntered_Click(object sender, EventArgs e)
        {
            if (employeeService.GetEmployeesByElement(new Employee(textBoxEmail.Text).ToBsonDocument().GetElement("email")).Count != 0)
            {
                var client = new SmtpClient("smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("aee2f8f4701483", "119bbc2e9eaa33"),
                    EnableSsl = true
                };
                client.Send("Support@TGG.com", textBoxEmail.Text, "Reset Password", "Your confirmation code is: ");
                resetPasswordService.InsertValidationCode(new TGGValidation(textBoxEmail.Text, encryptionService.HashWithSalt(RandomString())));
            }
            panelEnterEmail.Hide();

        }
        public static string RandomString()
        {
            Random r = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[r.Next(s.Length)]).ToArray());
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack2EmailEnter_Click(object sender, EventArgs e)
        {
            panelEnterEmail.Show();
        }

        private void buttonConfirmCode_Click(object sender, EventArgs e)
        {

        }
    }
}
