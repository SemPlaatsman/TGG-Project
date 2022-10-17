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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.gridViewEmployees = new System.Windows.Forms.DataGridView();
            this.lblEmployeeOverview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewEmployees.DefaultCellStyle = dataGridViewCellStyle20;
            this.gridViewEmployees.GridColor = System.Drawing.Color.Black;
            this.gridViewEmployees.Location = new System.Drawing.Point(70, 160);
            this.gridViewEmployees.MultiSelect = false;
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
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
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(884, 951);
            this.Controls.Add(this.lblEmployeeOverview);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.gridViewEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee overview";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView gridViewEmployees;
        private System.Windows.Forms.Label lblEmployeeOverview;
    }
}