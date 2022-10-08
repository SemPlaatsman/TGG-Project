
namespace TGG_UI
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTitleHighUrg = new System.Windows.Forms.Label();
            this.labelAmountPendingHU = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOpenHighUrg = new System.Windows.Forms.Panel();
            this.panelOpenPendingNU = new System.Windows.Forms.Panel();
            this.panelPendingHighUrg = new System.Windows.Forms.Panel();
            this.panelOpenPendingLowUrg = new System.Windows.Forms.Panel();
            this.labelTitleOpenHU = new System.Windows.Forms.Label();
            this.labelAmountOpenHU = new System.Windows.Forms.Label();
            this.labelTitleOpenPendingNU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitleOverdue = new System.Windows.Forms.Label();
            this.pictureBoxOverdue = new System.Windows.Forms.PictureBox();
            this.pictureBoxHighUrg = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpenHighUrg = new System.Windows.Forms.PictureBox();
            this.pictureBoxNormalUrgency = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelOpenHighUrg.SuspendLayout();
            this.panelOpenPendingNU.SuspendLayout();
            this.panelPendingHighUrg.SuspendLayout();
            this.panelOpenPendingLowUrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverdue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHighUrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenHighUrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormalUrgency)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(17, 211);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Tickets Status";
            dataPoint3.Color = System.Drawing.Color.SeaGreen;
            dataPoint3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint3.LabelForeColor = System.Drawing.Color.White;
            series3.Points.Add(dataPoint3);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(353, 323);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // labelTitleHighUrg
            // 
            this.labelTitleHighUrg.AutoSize = true;
            this.labelTitleHighUrg.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleHighUrg.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleHighUrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelTitleHighUrg.Location = new System.Drawing.Point(59, 18);
            this.labelTitleHighUrg.Name = "labelTitleHighUrg";
            this.labelTitleHighUrg.Size = new System.Drawing.Size(222, 16);
            this.labelTitleHighUrg.TabIndex = 2;
            this.labelTitleHighUrg.Text = "Pending High Urgency Tickets:";
            // 
            // labelAmountPendingHU
            // 
            this.labelAmountPendingHU.AutoSize = true;
            this.labelAmountPendingHU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountPendingHU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelAmountPendingHU.Location = new System.Drawing.Point(60, 34);
            this.labelAmountPendingHU.Name = "labelAmountPendingHU";
            this.labelAmountPendingHU.Size = new System.Drawing.Size(22, 23);
            this.labelAmountPendingHU.TabIndex = 3;
            this.labelAmountPendingHU.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panelOpenPendingLowUrg);
            this.flowLayoutPanel1.Controls.Add(this.panelPendingHighUrg);
            this.flowLayoutPanel1.Controls.Add(this.panelOpenHighUrg);
            this.flowLayoutPanel1.Controls.Add(this.panelOpenPendingNU);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1124, 104);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panelOpenHighUrg
            // 
            this.panelOpenHighUrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpenHighUrg.Controls.Add(this.labelAmountOpenHU);
            this.panelOpenHighUrg.Controls.Add(this.pictureBoxOpenHighUrg);
            this.panelOpenHighUrg.Controls.Add(this.labelTitleOpenHU);
            this.panelOpenHighUrg.Location = new System.Drawing.Point(558, 0);
            this.panelOpenHighUrg.Margin = new System.Windows.Forms.Padding(0);
            this.panelOpenHighUrg.Name = "panelOpenHighUrg";
            this.panelOpenHighUrg.Size = new System.Drawing.Size(281, 100);
            this.panelOpenHighUrg.TabIndex = 0;
            // 
            // panelOpenPendingNU
            // 
            this.panelOpenPendingNU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpenPendingNU.Controls.Add(this.label1);
            this.panelOpenPendingNU.Controls.Add(this.pictureBoxNormalUrgency);
            this.panelOpenPendingNU.Controls.Add(this.labelTitleOpenPendingNU);
            this.panelOpenPendingNU.Location = new System.Drawing.Point(839, 0);
            this.panelOpenPendingNU.Margin = new System.Windows.Forms.Padding(0);
            this.panelOpenPendingNU.Name = "panelOpenPendingNU";
            this.panelOpenPendingNU.Size = new System.Drawing.Size(281, 100);
            this.panelOpenPendingNU.TabIndex = 1;
            // 
            // panelPendingHighUrg
            // 
            this.panelPendingHighUrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPendingHighUrg.Controls.Add(this.labelTitleHighUrg);
            this.panelPendingHighUrg.Controls.Add(this.pictureBoxHighUrg);
            this.panelPendingHighUrg.Controls.Add(this.labelAmountPendingHU);
            this.panelPendingHighUrg.Location = new System.Drawing.Point(277, 0);
            this.panelPendingHighUrg.Margin = new System.Windows.Forms.Padding(0);
            this.panelPendingHighUrg.Name = "panelPendingHighUrg";
            this.panelPendingHighUrg.Size = new System.Drawing.Size(281, 100);
            this.panelPendingHighUrg.TabIndex = 2;
            // 
            // panelOpenPendingLowUrg
            // 
            this.panelOpenPendingLowUrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpenPendingLowUrg.Controls.Add(this.label2);
            this.panelOpenPendingLowUrg.Controls.Add(this.pictureBoxOverdue);
            this.panelOpenPendingLowUrg.Controls.Add(this.labelTitleOverdue);
            this.panelOpenPendingLowUrg.Location = new System.Drawing.Point(0, 0);
            this.panelOpenPendingLowUrg.Margin = new System.Windows.Forms.Padding(0);
            this.panelOpenPendingLowUrg.Name = "panelOpenPendingLowUrg";
            this.panelOpenPendingLowUrg.Size = new System.Drawing.Size(277, 100);
            this.panelOpenPendingLowUrg.TabIndex = 3;
            // 
            // labelTitleOpenHU
            // 
            this.labelTitleOpenHU.AutoSize = true;
            this.labelTitleOpenHU.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleOpenHU.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleOpenHU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelTitleOpenHU.Location = new System.Drawing.Point(66, 18);
            this.labelTitleOpenHU.Name = "labelTitleOpenHU";
            this.labelTitleOpenHU.Size = new System.Drawing.Size(202, 16);
            this.labelTitleOpenHU.TabIndex = 3;
            this.labelTitleOpenHU.Text = "Open High Urgency Tickets:";
            // 
            // labelAmountOpenHU
            // 
            this.labelAmountOpenHU.AutoSize = true;
            this.labelAmountOpenHU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountOpenHU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelAmountOpenHU.Location = new System.Drawing.Point(60, 34);
            this.labelAmountOpenHU.Name = "labelAmountOpenHU";
            this.labelAmountOpenHU.Size = new System.Drawing.Size(22, 23);
            this.labelAmountOpenHU.TabIndex = 5;
            this.labelAmountOpenHU.Text = "0";
            // 
            // labelTitleOpenPendingNU
            // 
            this.labelTitleOpenPendingNU.AutoSize = true;
            this.labelTitleOpenPendingNU.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleOpenPendingNU.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleOpenPendingNU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelTitleOpenPendingNU.Location = new System.Drawing.Point(66, 2);
            this.labelTitleOpenPendingNU.Name = "labelTitleOpenPendingNU";
            this.labelTitleOpenPendingNU.Size = new System.Drawing.Size(188, 32);
            this.labelTitleOpenPendingNU.TabIndex = 4;
            this.labelTitleOpenPendingNU.Text = "Open or Pending Normal/ \r\nLow Urgency Tickets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // labelTitleOverdue
            // 
            this.labelTitleOverdue.AutoSize = true;
            this.labelTitleOverdue.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleOverdue.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleOverdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelTitleOverdue.Location = new System.Drawing.Point(59, 18);
            this.labelTitleOverdue.Name = "labelTitleOverdue";
            this.labelTitleOverdue.Size = new System.Drawing.Size(128, 16);
            this.labelTitleOverdue.TabIndex = 3;
            this.labelTitleOverdue.Text = "Overdue Tickets:";
            // 
            // pictureBoxOverdue
            // 
            this.pictureBoxOverdue.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOverdue.Location = new System.Drawing.Point(0, 18);
            this.pictureBoxOverdue.Name = "pictureBoxOverdue";
            this.pictureBoxOverdue.Size = new System.Drawing.Size(60, 57);
            this.pictureBoxOverdue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOverdue.TabIndex = 4;
            this.pictureBoxOverdue.TabStop = false;
            // 
            // pictureBoxHighUrg
            // 
            this.pictureBoxHighUrg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHighUrg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHighUrg.Image")));
            this.pictureBoxHighUrg.Location = new System.Drawing.Point(0, 18);
            this.pictureBoxHighUrg.Name = "pictureBoxHighUrg";
            this.pictureBoxHighUrg.Size = new System.Drawing.Size(60, 57);
            this.pictureBoxHighUrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHighUrg.TabIndex = 1;
            this.pictureBoxHighUrg.TabStop = false;
            // 
            // pictureBoxOpenHighUrg
            // 
            this.pictureBoxOpenHighUrg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOpenHighUrg.Image = global::TGG_UI.Properties.Resources.noun_urgent_3883376;
            this.pictureBoxOpenHighUrg.Location = new System.Drawing.Point(0, 18);
            this.pictureBoxOpenHighUrg.Name = "pictureBoxOpenHighUrg";
            this.pictureBoxOpenHighUrg.Size = new System.Drawing.Size(60, 57);
            this.pictureBoxOpenHighUrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpenHighUrg.TabIndex = 4;
            this.pictureBoxOpenHighUrg.TabStop = false;
            // 
            // pictureBoxNormalUrgency
            // 
            this.pictureBoxNormalUrgency.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNormalUrgency.Image = global::TGG_UI.Properties.Resources.noun_urgent_3883376;
            this.pictureBoxNormalUrgency.Location = new System.Drawing.Point(0, 18);
            this.pictureBoxNormalUrgency.Name = "pictureBoxNormalUrgency";
            this.pictureBoxNormalUrgency.Size = new System.Drawing.Size(60, 57);
            this.pictureBoxNormalUrgency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNormalUrgency.TabIndex = 5;
            this.pictureBoxNormalUrgency.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(60, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1149, 601);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelOpenHighUrg.ResumeLayout(false);
            this.panelOpenHighUrg.PerformLayout();
            this.panelOpenPendingNU.ResumeLayout(false);
            this.panelOpenPendingNU.PerformLayout();
            this.panelPendingHighUrg.ResumeLayout(false);
            this.panelPendingHighUrg.PerformLayout();
            this.panelOpenPendingLowUrg.ResumeLayout(false);
            this.panelOpenPendingLowUrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverdue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHighUrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenHighUrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormalUrgency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBoxHighUrg;
        private System.Windows.Forms.Label labelTitleHighUrg;
        private System.Windows.Forms.Label labelAmountPendingHU;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelPendingHighUrg;
        private System.Windows.Forms.Panel panelOpenHighUrg;
        private System.Windows.Forms.Panel panelOpenPendingNU;
        private System.Windows.Forms.Panel panelOpenPendingLowUrg;
        private System.Windows.Forms.Label labelTitleOpenHU;
        private System.Windows.Forms.PictureBox pictureBoxOpenHighUrg;
        private System.Windows.Forms.Label labelAmountOpenHU;
        private System.Windows.Forms.Label labelTitleOpenPendingNU;
        private System.Windows.Forms.PictureBox pictureBoxOverdue;
        private System.Windows.Forms.Label labelTitleOverdue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxNormalUrgency;
        private System.Windows.Forms.Label label2;
    }
}