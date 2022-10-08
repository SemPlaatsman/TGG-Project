
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxHighUrg = new System.Windows.Forms.PictureBox();
            this.labelTitleHighUrg = new System.Windows.Forms.Label();
            this.labelAmountHighUrg = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOpenHighUrg = new System.Windows.Forms.Panel();
            this.panelOpenPendingMediumUrg = new System.Windows.Forms.Panel();
            this.panelPendingHighUrg = new System.Windows.Forms.Panel();
            this.panelOpenPendingLowUrg = new System.Windows.Forms.Panel();
            this.labelTitleOpenHU = new System.Windows.Forms.Label();
            this.pictureBoxOpenHighUrg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHighUrg)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelOpenHighUrg.SuspendLayout();
            this.panelPendingHighUrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenHighUrg)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(17, 211);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Tickets Status";
            dataPoint1.Color = System.Drawing.Color.SeaGreen;
            dataPoint1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint1.LabelForeColor = System.Drawing.Color.White;
            series1.Points.Add(dataPoint1);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(353, 323);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // labelAmountHighUrg
            // 
            this.labelAmountHighUrg.AutoSize = true;
            this.labelAmountHighUrg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountHighUrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.labelAmountHighUrg.Location = new System.Drawing.Point(60, 34);
            this.labelAmountHighUrg.Name = "labelAmountHighUrg";
            this.labelAmountHighUrg.Size = new System.Drawing.Size(22, 23);
            this.labelAmountHighUrg.TabIndex = 3;
            this.labelAmountHighUrg.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panelPendingHighUrg);
            this.flowLayoutPanel1.Controls.Add(this.panelOpenHighUrg);
            this.flowLayoutPanel1.Controls.Add(this.panelOpenPendingMediumUrg);
            this.flowLayoutPanel1.Controls.Add(this.panelOpenPendingLowUrg);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1124, 104);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panelOpenHighUrg
            // 
            this.panelOpenHighUrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpenHighUrg.Controls.Add(this.label1);
            this.panelOpenHighUrg.Controls.Add(this.pictureBoxOpenHighUrg);
            this.panelOpenHighUrg.Controls.Add(this.labelTitleOpenHU);
            this.panelOpenHighUrg.Location = new System.Drawing.Point(281, 0);
            this.panelOpenHighUrg.Margin = new System.Windows.Forms.Padding(0);
            this.panelOpenHighUrg.Name = "panelOpenHighUrg";
            this.panelOpenHighUrg.Size = new System.Drawing.Size(281, 100);
            this.panelOpenHighUrg.TabIndex = 0;
            // 
            // panelOpenPendingMediumUrg
            // 
            this.panelOpenPendingMediumUrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpenPendingMediumUrg.Location = new System.Drawing.Point(562, 0);
            this.panelOpenPendingMediumUrg.Margin = new System.Windows.Forms.Padding(0);
            this.panelOpenPendingMediumUrg.Name = "panelOpenPendingMediumUrg";
            this.panelOpenPendingMediumUrg.Size = new System.Drawing.Size(281, 100);
            this.panelOpenPendingMediumUrg.TabIndex = 1;
            // 
            // panelPendingHighUrg
            // 
            this.panelPendingHighUrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPendingHighUrg.Controls.Add(this.labelTitleHighUrg);
            this.panelPendingHighUrg.Controls.Add(this.pictureBoxHighUrg);
            this.panelPendingHighUrg.Controls.Add(this.labelAmountHighUrg);
            this.panelPendingHighUrg.Location = new System.Drawing.Point(0, 0);
            this.panelPendingHighUrg.Margin = new System.Windows.Forms.Padding(0);
            this.panelPendingHighUrg.Name = "panelPendingHighUrg";
            this.panelPendingHighUrg.Size = new System.Drawing.Size(281, 100);
            this.panelPendingHighUrg.TabIndex = 2;
            // 
            // panelOpenPendingLowUrg
            // 
            this.panelOpenPendingLowUrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpenPendingLowUrg.Location = new System.Drawing.Point(843, 0);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHighUrg)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelOpenHighUrg.ResumeLayout(false);
            this.panelOpenHighUrg.PerformLayout();
            this.panelPendingHighUrg.ResumeLayout(false);
            this.panelPendingHighUrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenHighUrg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBoxHighUrg;
        private System.Windows.Forms.Label labelTitleHighUrg;
        private System.Windows.Forms.Label labelAmountHighUrg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelPendingHighUrg;
        private System.Windows.Forms.Panel panelOpenHighUrg;
        private System.Windows.Forms.Panel panelOpenPendingMediumUrg;
        private System.Windows.Forms.Panel panelOpenPendingLowUrg;
        private System.Windows.Forms.Label labelTitleOpenHU;
        private System.Windows.Forms.PictureBox pictureBoxOpenHighUrg;
        private System.Windows.Forms.Label label1;
    }
}