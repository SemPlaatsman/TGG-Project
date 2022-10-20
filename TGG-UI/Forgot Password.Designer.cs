
namespace TGG_UI
{
    partial class ForgotPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitleEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonNextEmailEntered = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTitleEnterCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.panelEnterEmail = new System.Windows.Forms.Panel();
            this.panelEnterCode = new System.Windows.Forms.Panel();
            this.buttonConfirmCode = new System.Windows.Forms.Button();
            this.buttonBack2EmailEnter = new System.Windows.Forms.Button();
            this.panelResetPassword = new System.Windows.Forms.Panel();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.labelEnterNewPass = new System.Windows.Forms.Label();
            this.textBoxEnterPass = new System.Windows.Forms.TextBox();
            this.buttonConfirmNewPassword = new System.Windows.Forms.Button();
            this.labelExtraInformation = new System.Windows.Forms.Label();
            this.panelEnterEmail.SuspendLayout();
            this.panelEnterCode.SuspendLayout();
            this.panelResetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleEmail
            // 
            this.labelTitleEmail.AutoSize = true;
            this.labelTitleEmail.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleEmail.Location = new System.Drawing.Point(0, 0);
            this.labelTitleEmail.Name = "labelTitleEmail";
            this.labelTitleEmail.Size = new System.Drawing.Size(205, 22);
            this.labelTitleEmail.TabIndex = 0;
            this.labelTitleEmail.Text = "Enter Email Address:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(2, 54);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(275, 27);
            this.textBoxEmail.TabIndex = 1;
            // 
            // buttonNextEmailEntered
            // 
            this.buttonNextEmailEntered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonNextEmailEntered.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNextEmailEntered.FlatAppearance.BorderSize = 0;
            this.buttonNextEmailEntered.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonNextEmailEntered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextEmailEntered.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextEmailEntered.ForeColor = System.Drawing.Color.White;
            this.buttonNextEmailEntered.Location = new System.Drawing.Point(2, 156);
            this.buttonNextEmailEntered.Name = "buttonNextEmailEntered";
            this.buttonNextEmailEntered.Size = new System.Drawing.Size(275, 57);
            this.buttonNextEmailEntered.TabIndex = 6;
            this.buttonNextEmailEntered.Text = "Next";
            this.buttonNextEmailEntered.UseVisualStyleBackColor = false;
            this.buttonNextEmailEntered.Click += new System.EventHandler(this.buttonNextEmailEntered_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(2, 219);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(275, 57);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTitleEnterCode
            // 
            this.labelTitleEnterCode.AutoSize = true;
            this.labelTitleEnterCode.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleEnterCode.Location = new System.Drawing.Point(0, 0);
            this.labelTitleEnterCode.Name = "labelTitleEnterCode";
            this.labelTitleEnterCode.Size = new System.Drawing.Size(203, 22);
            this.labelTitleEnterCode.TabIndex = 8;
            this.labelTitleEnterCode.Text = "Enter code recieved:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.White;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCode.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(2, 54);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(275, 28);
            this.textBoxCode.TabIndex = 9;
            // 
            // panelEnterEmail
            // 
            this.panelEnterEmail.Controls.Add(this.buttonNextEmailEntered);
            this.panelEnterEmail.Controls.Add(this.buttonCancel);
            this.panelEnterEmail.Controls.Add(this.textBoxEmail);
            this.panelEnterEmail.Controls.Add(this.labelTitleEmail);
            this.panelEnterEmail.Location = new System.Drawing.Point(137, 203);
            this.panelEnterEmail.Name = "panelEnterEmail";
            this.panelEnterEmail.Size = new System.Drawing.Size(305, 290);
            this.panelEnterEmail.TabIndex = 11;
            // 
            // panelEnterCode
            // 
            this.panelEnterCode.Controls.Add(this.labelTitleEnterCode);
            this.panelEnterCode.Controls.Add(this.textBoxCode);
            this.panelEnterCode.Controls.Add(this.buttonConfirmCode);
            this.panelEnterCode.Controls.Add(this.buttonBack2EmailEnter);
            this.panelEnterCode.Location = new System.Drawing.Point(137, 203);
            this.panelEnterCode.Name = "panelEnterCode";
            this.panelEnterCode.Size = new System.Drawing.Size(305, 290);
            this.panelEnterCode.TabIndex = 12;
            // 
            // buttonConfirmCode
            // 
            this.buttonConfirmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonConfirmCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConfirmCode.FlatAppearance.BorderSize = 0;
            this.buttonConfirmCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonConfirmCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmCode.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmCode.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmCode.Location = new System.Drawing.Point(2, 156);
            this.buttonConfirmCode.Name = "buttonConfirmCode";
            this.buttonConfirmCode.Size = new System.Drawing.Size(275, 57);
            this.buttonConfirmCode.TabIndex = 6;
            this.buttonConfirmCode.Text = "Confirm Code";
            this.buttonConfirmCode.UseVisualStyleBackColor = false;
            this.buttonConfirmCode.Click += new System.EventHandler(this.buttonConfirmCode_Click);
            // 
            // buttonBack2EmailEnter
            // 
            this.buttonBack2EmailEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonBack2EmailEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBack2EmailEnter.FlatAppearance.BorderSize = 0;
            this.buttonBack2EmailEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonBack2EmailEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack2EmailEnter.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack2EmailEnter.ForeColor = System.Drawing.Color.White;
            this.buttonBack2EmailEnter.Location = new System.Drawing.Point(2, 219);
            this.buttonBack2EmailEnter.Name = "buttonBack2EmailEnter";
            this.buttonBack2EmailEnter.Size = new System.Drawing.Size(275, 57);
            this.buttonBack2EmailEnter.TabIndex = 7;
            this.buttonBack2EmailEnter.Text = "Back";
            this.buttonBack2EmailEnter.UseVisualStyleBackColor = false;
            this.buttonBack2EmailEnter.Click += new System.EventHandler(this.buttonBack2EmailEnter_Click);
            // 
            // panelResetPassword
            // 
            this.panelResetPassword.Controls.Add(this.labelConfirmPassword);
            this.panelResetPassword.Controls.Add(this.textBoxConfirmPass);
            this.panelResetPassword.Controls.Add(this.labelEnterNewPass);
            this.panelResetPassword.Controls.Add(this.textBoxEnterPass);
            this.panelResetPassword.Controls.Add(this.buttonConfirmNewPassword);
            this.panelResetPassword.Location = new System.Drawing.Point(137, 203);
            this.panelResetPassword.Name = "panelResetPassword";
            this.panelResetPassword.Size = new System.Drawing.Size(305, 290);
            this.panelResetPassword.TabIndex = 13;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(-2, 60);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(189, 22);
            this.labelConfirmPassword.TabIndex = 10;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.BackColor = System.Drawing.Color.White;
            this.textBoxConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPass.Location = new System.Drawing.Point(0, 85);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.PasswordChar = '◍';
            this.textBoxConfirmPass.Size = new System.Drawing.Size(275, 28);
            this.textBoxConfirmPass.TabIndex = 11;
            // 
            // labelEnterNewPass
            // 
            this.labelEnterNewPass.AutoSize = true;
            this.labelEnterNewPass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNewPass.Location = new System.Drawing.Point(0, 0);
            this.labelEnterNewPass.Name = "labelEnterNewPass";
            this.labelEnterNewPass.Size = new System.Drawing.Size(207, 22);
            this.labelEnterNewPass.TabIndex = 8;
            this.labelEnterNewPass.Text = "Enter new password:";
            // 
            // textBoxEnterPass
            // 
            this.textBoxEnterPass.BackColor = System.Drawing.Color.White;
            this.textBoxEnterPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnterPass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterPass.Location = new System.Drawing.Point(2, 25);
            this.textBoxEnterPass.Name = "textBoxEnterPass";
            this.textBoxEnterPass.PasswordChar = '◍';
            this.textBoxEnterPass.Size = new System.Drawing.Size(275, 28);
            this.textBoxEnterPass.TabIndex = 9;
            // 
            // buttonConfirmNewPassword
            // 
            this.buttonConfirmNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonConfirmNewPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConfirmNewPassword.FlatAppearance.BorderSize = 0;
            this.buttonConfirmNewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonConfirmNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmNewPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmNewPassword.Location = new System.Drawing.Point(2, 156);
            this.buttonConfirmNewPassword.Name = "buttonConfirmNewPassword";
            this.buttonConfirmNewPassword.Size = new System.Drawing.Size(275, 120);
            this.buttonConfirmNewPassword.TabIndex = 6;
            this.buttonConfirmNewPassword.Text = "Confirm New Password";
            this.buttonConfirmNewPassword.UseVisualStyleBackColor = false;
            this.buttonConfirmNewPassword.Click += new System.EventHandler(this.buttonConfirmNewPassword_Click);
            // 
            // labelExtraInformation
            // 
            this.labelExtraInformation.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtraInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.labelExtraInformation.Location = new System.Drawing.Point(135, 64);
            this.labelExtraInformation.Name = "labelExtraInformation";
            this.labelExtraInformation.Size = new System.Drawing.Size(307, 136);
            this.labelExtraInformation.TabIndex = 14;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 577);
            this.Controls.Add(this.labelExtraInformation);
            this.Controls.Add(this.panelEnterEmail);
            this.Controls.Add(this.panelEnterCode);
            this.Controls.Add(this.panelResetPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelEnterEmail.ResumeLayout(false);
            this.panelEnterEmail.PerformLayout();
            this.panelEnterCode.ResumeLayout(false);
            this.panelEnterCode.PerformLayout();
            this.panelResetPassword.ResumeLayout(false);
            this.panelResetPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitleEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonNextEmailEntered;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTitleEnterCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Panel panelEnterEmail;
        private System.Windows.Forms.Panel panelEnterCode;
        private System.Windows.Forms.Button buttonConfirmCode;
        private System.Windows.Forms.Button buttonBack2EmailEnter;
        private System.Windows.Forms.Panel panelResetPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Label labelEnterNewPass;
        private System.Windows.Forms.TextBox textBoxEnterPass;
        private System.Windows.Forms.Button buttonConfirmNewPassword;
        private System.Windows.Forms.Label labelExtraInformation;
    }
}