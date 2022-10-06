
namespace TGG_UI
{
    partial class Form1
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
            this.programTitleLable = new System.Windows.Forms.Label();
            this.gardenGroupTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programTitleLable
            // 
            this.programTitleLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(172)))), ((int)(((byte)(79)))));
            this.programTitleLable.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programTitleLable.ForeColor = System.Drawing.Color.White;
            this.programTitleLable.Location = new System.Drawing.Point(0, 0);
            this.programTitleLable.Name = "programTitleLable";
            this.programTitleLable.Size = new System.Drawing.Size(1140, 88);
            this.programTitleLable.TabIndex = 0;
            this.programTitleLable.Text = "NODESK";
            this.programTitleLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gardenGroupTitle
            // 
            this.gardenGroupTitle.AutoSize = true;
            this.gardenGroupTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(172)))), ((int)(((byte)(79)))));
            this.gardenGroupTitle.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gardenGroupTitle.ForeColor = System.Drawing.Color.White;
            this.gardenGroupTitle.Location = new System.Drawing.Point(954, 59);
            this.gardenGroupTitle.Name = "gardenGroupTitle";
            this.gardenGroupTitle.Size = new System.Drawing.Size(186, 29);
            this.gardenGroupTitle.TabIndex = 1;
            this.gardenGroupTitle.Text = "The Garden Group";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 88);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1140, 68);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(775, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(353, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 513);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gardenGroupTitle);
            this.Controls.Add(this.programTitleLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programTitleLable;
        private System.Windows.Forms.Label gardenGroupTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}