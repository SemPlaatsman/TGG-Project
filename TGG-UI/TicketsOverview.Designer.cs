
namespace TGG_UI
{
    partial class TicketsOverview
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
            this.gridViewTickets = new System.Windows.Forms.DataGridView();
            this.buttonAddTicketsForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewTickets
            // 
            this.gridViewTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.gridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTickets.GridColor = System.Drawing.Color.Black;
            this.gridViewTickets.Location = new System.Drawing.Point(70, 160);
            this.gridViewTickets.Name = "gridViewTickets";
            this.gridViewTickets.Size = new System.Drawing.Size(744, 690);
            this.gridViewTickets.TabIndex = 0;
            // 
            // buttonAddTicketsForm
            // 
            this.buttonAddTicketsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonAddTicketsForm.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTicketsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(190)))), ((int)(((byte)(188)))));
            this.buttonAddTicketsForm.Location = new System.Drawing.Point(549, 79);
            this.buttonAddTicketsForm.Name = "buttonAddTicketsForm";
            this.buttonAddTicketsForm.Size = new System.Drawing.Size(266, 54);
            this.buttonAddTicketsForm.TabIndex = 1;
            this.buttonAddTicketsForm.Text = "Add Tickets";
            this.buttonAddTicketsForm.UseVisualStyleBackColor = false;
            this.buttonAddTicketsForm.Click += new System.EventHandler(this.buttonAddTicketsForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(190)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(64, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Overview Tickets";
            // 
            // TicketsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(884, 951);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddTicketsForm);
            this.Controls.Add(this.gridViewTickets);
            this.Name = "TicketsOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewTickets;
        private System.Windows.Forms.Button buttonAddTicketsForm;
        private System.Windows.Forms.Label label1;
    }
}