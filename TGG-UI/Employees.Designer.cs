namespace TGG_UI
{
    partial class Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.gridViewEmployees = new System.Windows.Forms.DataGridView();
            this.lblEmployeeOverview = new System.Windows.Forms.Label();
            this.navigationBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.employeeOverviewButton = new System.Windows.Forms.Button();
            this.ticketOverviewButton = new System.Windows.Forms.Button();
            this.dashBoardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
            this.navigationBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddEmployee.Location = new System.Drawing.Point(548, 100);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(266, 54);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.AllowUserToAddRows = false;
            this.gridViewEmployees.AllowUserToDeleteRows = false;
            this.gridViewEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewEmployees.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridViewEmployees.GridColor = System.Drawing.Color.Black;
            this.gridViewEmployees.Location = new System.Drawing.Point(70, 160);
            this.gridViewEmployees.MultiSelect = false;
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridViewEmployees.RowHeadersVisible = false;
            this.gridViewEmployees.Size = new System.Drawing.Size(744, 690);
            this.gridViewEmployees.TabIndex = 3;
            // 
            // lblEmployeeOverview
            // 
            this.lblEmployeeOverview.AutoSize = true;
            this.lblEmployeeOverview.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.lblEmployeeOverview.Location = new System.Drawing.Point(63, 106);
            this.lblEmployeeOverview.Name = "lblEmployeeOverview";
            this.lblEmployeeOverview.Size = new System.Drawing.Size(313, 37);
            this.lblEmployeeOverview.TabIndex = 5;
            this.lblEmployeeOverview.Text = "Employee Overview";
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
            this.navigationBarPanel.Location = new System.Drawing.Point(9, 9);
            this.navigationBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.navigationBarPanel.Name = "navigationBarPanel";
            this.navigationBarPanel.RowCount = 1;
            this.navigationBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationBarPanel.Size = new System.Drawing.Size(866, 41);
            this.navigationBarPanel.TabIndex = 6;
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(650, 5);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(211, 31);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log out  →";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // employeeOverviewButton
            // 
            this.employeeOverviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.employeeOverviewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeOverviewButton.Enabled = false;
            this.employeeOverviewButton.FlatAppearance.BorderSize = 0;
            this.employeeOverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeOverviewButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeOverviewButton.ForeColor = System.Drawing.Color.White;
            this.employeeOverviewButton.Location = new System.Drawing.Point(435, 5);
            this.employeeOverviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.employeeOverviewButton.Name = "employeeOverviewButton";
            this.employeeOverviewButton.Size = new System.Drawing.Size(208, 31);
            this.employeeOverviewButton.TabIndex = 3;
            this.employeeOverviewButton.Text = "Employee Managment";
            this.employeeOverviewButton.UseVisualStyleBackColor = false;
            // 
            // ticketOverviewButton
            // 
            this.ticketOverviewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketOverviewButton.FlatAppearance.BorderSize = 0;
            this.ticketOverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketOverviewButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketOverviewButton.ForeColor = System.Drawing.Color.White;
            this.ticketOverviewButton.Location = new System.Drawing.Point(220, 5);
            this.ticketOverviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.ticketOverviewButton.Name = "ticketOverviewButton";
            this.ticketOverviewButton.Size = new System.Drawing.Size(208, 31);
            this.ticketOverviewButton.TabIndex = 2;
            this.ticketOverviewButton.Text = "Ticket Management";
            this.ticketOverviewButton.UseVisualStyleBackColor = true;
            this.ticketOverviewButton.Click += new System.EventHandler(this.ticketOverviewButton_Click);
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
            this.dashBoardButton.Size = new System.Drawing.Size(208, 31);
            this.dashBoardButton.TabIndex = 1;
            this.dashBoardButton.Text = "Dashboard";
            this.dashBoardButton.UseVisualStyleBackColor = false;
            this.dashBoardButton.Click += new System.EventHandler(this.dashBoardButton_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(884, 951);
            this.Controls.Add(this.navigationBarPanel);
            this.Controls.Add(this.lblEmployeeOverview);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.gridViewEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee overview";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            this.navigationBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView gridViewEmployees;
        private System.Windows.Forms.Label lblEmployeeOverview;
        private System.Windows.Forms.TableLayoutPanel navigationBarPanel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button employeeOverviewButton;
        private System.Windows.Forms.Button ticketOverviewButton;
        private System.Windows.Forms.Button dashBoardButton;
    }
}