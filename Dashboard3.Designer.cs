namespace sprint_2_draft
{
    partial class Dashboard3
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
            this.DSS3 = new System.Windows.Forms.Button();
            this.DSS2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dashboard_System = new System.Windows.Forms.Label();
            this.Previous_Screen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DSS1 = new System.Windows.Forms.Button();
            this.HeadCount = new System.Windows.Forms.Label();
            this.progressbar21 = new sprint_2_draft.Progressbar2();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DSS3
            // 
            this.DSS3.Location = new System.Drawing.Point(26, 405);
            this.DSS3.Name = "DSS3";
            this.DSS3.Size = new System.Drawing.Size(215, 95);
            this.DSS3.TabIndex = 15;
            this.DSS3.Text = "DSS3";
            this.DSS3.UseVisualStyleBackColor = true;
            this.DSS3.Click += new System.EventHandler(this.DSS3_Click);
            // 
            // DSS2
            // 
            this.DSS2.Location = new System.Drawing.Point(26, 278);
            this.DSS2.Name = "DSS2";
            this.DSS2.Size = new System.Drawing.Size(215, 99);
            this.DSS2.TabIndex = 14;
            this.DSS2.Text = "DSS2";
            this.DSS2.UseVisualStyleBackColor = true;
            this.DSS2.Click += new System.EventHandler(this.DSS2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.Dashboard_System);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 103);
            this.panel3.TabIndex = 13;
            // 
            // Dashboard_System
            // 
            this.Dashboard_System.AutoSize = true;
            this.Dashboard_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_System.Location = new System.Drawing.Point(3, 9);
            this.Dashboard_System.Name = "Dashboard_System";
            this.Dashboard_System.Size = new System.Drawing.Size(263, 33);
            this.Dashboard_System.TabIndex = 13;
            this.Dashboard_System.Text = "Dashboard System";
            // 
            // Previous_Screen
            // 
            this.Previous_Screen.Location = new System.Drawing.Point(26, 526);
            this.Previous_Screen.Margin = new System.Windows.Forms.Padding(2);
            this.Previous_Screen.Name = "Previous_Screen";
            this.Previous_Screen.Size = new System.Drawing.Size(99, 27);
            this.Previous_Screen.TabIndex = 10;
            this.Previous_Screen.Text = "Previous Screen";
            this.Previous_Screen.UseVisualStyleBackColor = true;
            this.Previous_Screen.Click += new System.EventHandler(this.Previous_Screen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.DSS1);
            this.panel1.Controls.Add(this.DSS3);
            this.panel1.Controls.Add(this.DSS2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Previous_Screen);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 579);
            this.panel1.TabIndex = 13;
            // 
            // DSS1
            // 
            this.DSS1.Location = new System.Drawing.Point(26, 152);
            this.DSS1.Name = "DSS1";
            this.DSS1.Size = new System.Drawing.Size(215, 99);
            this.DSS1.TabIndex = 17;
            this.DSS1.Text = "DSS1";
            this.DSS1.UseVisualStyleBackColor = true;
            this.DSS1.Click += new System.EventHandler(this.DSS1_Click);
            // 
            // HeadCount
            // 
            this.HeadCount.AutoSize = true;
            this.HeadCount.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HeadCount.Location = new System.Drawing.Point(298, 195);
            this.HeadCount.Name = "HeadCount";
            this.HeadCount.Size = new System.Drawing.Size(300, 22);
            this.HeadCount.TabIndex = 15;
            this.HeadCount.Text = "Total Head count of Employees";
            // 
            // progressbar21
            // 
            this.progressbar21.BackColor = System.Drawing.SystemColors.Window;
            this.progressbar21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressbar21.ForeColor = System.Drawing.SystemColors.Highlight;
            this.progressbar21.Location = new System.Drawing.Point(367, 67);
            this.progressbar21.Name = "progressbar21";
            this.progressbar21.Size = new System.Drawing.Size(151, 125);
            this.progressbar21.TabIndex = 14;
            this.progressbar21.Value = 9F;
            this.progressbar21.Load += new System.EventHandler(this.progressbar21_Load);
            // 
            // Dashboard3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 579);
            this.Controls.Add(this.HeadCount);
            this.Controls.Add(this.progressbar21);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard3";
            this.Text = "Dashboard3";
            this.Load += new System.EventHandler(this.Dashboard3_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DSS3;
        private System.Windows.Forms.Button DSS2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Dashboard_System;
        private System.Windows.Forms.Button Previous_Screen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DSS1;
        private Progressbar2 progressbar21;
        private System.Windows.Forms.Label HeadCount;
    }
}