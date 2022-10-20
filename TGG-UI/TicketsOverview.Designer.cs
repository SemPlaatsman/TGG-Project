
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
            this.buttonSortPriorityLevel = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.navigationBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.employeeOverviewButton = new System.Windows.Forms.Button();
            this.ticketOverviewButton = new System.Windows.Forms.Button();
            this.dashBoardButton = new System.Windows.Forms.Button();
            this.buttonDeleteTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTickets)).BeginInit();
            this.navigationBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewTickets
            // 
            this.gridViewTickets.AllowUserToAddRows = false;
            this.gridViewTickets.AllowUserToDeleteRows = false;
            this.gridViewTickets.AllowUserToResizeColumns = false;
            this.gridViewTickets.AllowUserToResizeRows = false;
            this.gridViewTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.gridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTickets.GridColor = System.Drawing.Color.Black;
            this.gridViewTickets.Location = new System.Drawing.Point(70, 160);
            this.gridViewTickets.MultiSelect = false;
            this.gridViewTickets.Name = "gridViewTickets";
            this.gridViewTickets.ReadOnly = true;
            this.gridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTickets.Size = new System.Drawing.Size(744, 690);
            this.gridViewTickets.TabIndex = 0;
            this.gridViewTickets.Tag = "ticketTag";
            // 
            // buttonAddTicketsForm
            // 
            this.buttonAddTicketsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonAddTicketsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonAddTicketsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(190)))), ((int)(((byte)(188)))));
            this.buttonAddTicketsForm.Location = new System.Drawing.Point(595, 90);
            this.buttonAddTicketsForm.Name = "buttonAddTicketsForm";
            this.buttonAddTicketsForm.Size = new System.Drawing.Size(219, 54);
            this.buttonAddTicketsForm.TabIndex = 1;
            this.buttonAddTicketsForm.Text = "Add Tickets";
            this.buttonAddTicketsForm.UseVisualStyleBackColor = false;
            this.buttonAddTicketsForm.Click += new System.EventHandler(this.buttonAddTicketsForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(190)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(306, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Overview Tickets";
            // 
            // buttonSortPriorityLevel
            // 
            this.buttonSortPriorityLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonSortPriorityLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortPriorityLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(190)))), ((int)(((byte)(188)))));
            this.buttonSortPriorityLevel.Location = new System.Drawing.Point(70, 90);
            this.buttonSortPriorityLevel.Name = "buttonSortPriorityLevel";
            this.buttonSortPriorityLevel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.buttonSortPriorityLevel.Size = new System.Drawing.Size(219, 54);
            this.buttonSortPriorityLevel.TabIndex = 3;
            this.buttonSortPriorityLevel.Text = "Sort Priority Level";
            this.buttonSortPriorityLevel.UseVisualStyleBackColor = false;
            this.buttonSortPriorityLevel.Click += new System.EventHandler(this.buttonSortPriorityLevel_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.btnArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(190)))), ((int)(((byte)(188)))));
            this.btnArchive.Location = new System.Drawing.Point(548, 867);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(266, 54);
            this.btnArchive.TabIndex = 3;
            this.btnArchive.Text = "Archive (> 2 years)";
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // navigationBarPanel
            // 
            this.navigationBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.navigationBarPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.navigationBarPanel.ColumnCount = 4;
            this.navigationBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationBarPanel.Controls.Add(this.logOutButton, 3, 0);
            this.navigationBarPanel.Controls.Add(this.employeeOverviewButton, 2, 0);
            this.navigationBarPanel.Controls.Add(this.ticketOverviewButton, 1, 0);
            this.navigationBarPanel.Controls.Add(this.dashBoardButton, 0, 0);
            this.navigationBarPanel.Location = new System.Drawing.Point(-1, 1);
            this.navigationBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.navigationBarPanel.Name = "navigationBarPanel";
            this.navigationBarPanel.RowCount = 1;
            this.navigationBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationBarPanel.Size = new System.Drawing.Size(884, 54);
            this.navigationBarPanel.TabIndex = 5;
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(665, 5);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(214, 44);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log out  →";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // employeeOverviewButton
            // 
            this.employeeOverviewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeOverviewButton.FlatAppearance.BorderSize = 0;
            this.employeeOverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeOverviewButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeOverviewButton.ForeColor = System.Drawing.Color.White;
            this.employeeOverviewButton.Location = new System.Drawing.Point(445, 5);
            this.employeeOverviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.employeeOverviewButton.Name = "employeeOverviewButton";
            this.employeeOverviewButton.Size = new System.Drawing.Size(213, 44);
            this.employeeOverviewButton.TabIndex = 3;
            this.employeeOverviewButton.Text = "Employee Managment";
            this.employeeOverviewButton.UseVisualStyleBackColor = true;
            this.employeeOverviewButton.Click += new System.EventHandler(this.employeeOverviewButton_Click);
            // 
            // ticketOverviewButton
            // 
            this.ticketOverviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.ticketOverviewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketOverviewButton.Enabled = false;
            this.ticketOverviewButton.FlatAppearance.BorderSize = 0;
            this.ticketOverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketOverviewButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketOverviewButton.ForeColor = System.Drawing.Color.White;
            this.ticketOverviewButton.Location = new System.Drawing.Point(225, 5);
            this.ticketOverviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.ticketOverviewButton.Name = "ticketOverviewButton";
            this.ticketOverviewButton.Size = new System.Drawing.Size(213, 44);
            this.ticketOverviewButton.TabIndex = 2;
            this.ticketOverviewButton.Text = "Ticket Management";
            this.ticketOverviewButton.UseVisualStyleBackColor = false;
            // 
            // dashBoardButton
            // 
            this.dashBoardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.dashBoardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoardButton.FlatAppearance.BorderSize = 0;
            this.dashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBoardButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardButton.ForeColor = System.Drawing.Color.White;
            this.dashBoardButton.Location = new System.Drawing.Point(5, 5);
            this.dashBoardButton.Margin = new System.Windows.Forms.Padding(2);
            this.dashBoardButton.Name = "dashBoardButton";
            this.dashBoardButton.Size = new System.Drawing.Size(213, 44);
            this.dashBoardButton.TabIndex = 1;
            this.dashBoardButton.Text = "Dashboard";
            this.dashBoardButton.UseVisualStyleBackColor = false;
            this.dashBoardButton.Click += new System.EventHandler(this.dashBoardButton_Click);
            // 
            // buttonDeleteTicket
            // 
            this.buttonDeleteTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonDeleteTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(190)))), ((int)(((byte)(188)))));
            this.buttonDeleteTicket.Location = new System.Drawing.Point(70, 867);
            this.buttonDeleteTicket.Name = "buttonDeleteTicket";
            this.buttonDeleteTicket.Size = new System.Drawing.Size(266, 54);
            this.buttonDeleteTicket.TabIndex = 6;
            this.buttonDeleteTicket.Text = "Delete Ticket";
            this.buttonDeleteTicket.UseVisualStyleBackColor = false;
            this.buttonDeleteTicket.Click += new System.EventHandler(this.buttonDeleteTicket_Click);
            // 
            // TicketsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(900, 990);
            this.Controls.Add(this.buttonDeleteTicket);
            this.Controls.Add(this.navigationBarPanel);
            this.Controls.Add(this.buttonSortPriorityLevel);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddTicketsForm);
            this.Controls.Add(this.gridViewTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 990);
            this.MinimumSize = new System.Drawing.Size(900, 990);
            this.Name = "TicketsOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTickets)).EndInit();
            this.navigationBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewTickets;
        private System.Windows.Forms.Button buttonAddTicketsForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSortPriorityLevel;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.TableLayoutPanel navigationBarPanel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button employeeOverviewButton;
        private System.Windows.Forms.Button ticketOverviewButton;
        private System.Windows.Forms.Button dashBoardButton;
        private System.Windows.Forms.Button buttonDeleteTicket;
    }
}