namespace sprint_2_draft
{
    partial class HR_page
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
            this.Headertext = new System.Windows.Forms.Label();
            this.HR = new System.Windows.Forms.Button();
            this.Owner = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Headertext
            // 
            this.Headertext.AutoSize = true;
            this.Headertext.BackColor = System.Drawing.Color.Transparent;
            this.Headertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headertext.Location = new System.Drawing.Point(47, 19);
            this.Headertext.Name = "Headertext";
            this.Headertext.Size = new System.Drawing.Size(606, 37);
            this.Headertext.TabIndex = 0;
            this.Headertext.Text = "Human Resource Management System";
            // 
            // HR
            // 
            this.HR.Location = new System.Drawing.Point(96, 116);
            this.HR.Name = "HR";
            this.HR.Size = new System.Drawing.Size(184, 81);
            this.HR.TabIndex = 1;
            this.HR.Text = "HR";
            this.HR.UseVisualStyleBackColor = true;
            this.HR.Click += new System.EventHandler(this.HR_Click);
            // 
            // Owner
            // 
            this.Owner.Location = new System.Drawing.Point(250, 238);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(184, 81);
            this.Owner.TabIndex = 2;
            this.Owner.Text = "Owner";
            this.Owner.UseVisualStyleBackColor = true;
            this.Owner.Click += new System.EventHandler(this.Owner_Click);
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(401, 116);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(184, 81);
            this.Employee.TabIndex = 3;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(539, 257);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(82, 62);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // HR_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::sprint_2_draft.Properties.Resources.realistic_water_drop_splash;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Owner);
            this.Controls.Add(this.HR);
            this.Controls.Add(this.Headertext);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HR_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource Management System with Payroll";
            this.Load += new System.EventHandler(this.HR_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Headertext;
        private System.Windows.Forms.Button HR;
        private System.Windows.Forms.Button Owner;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button Exit;
    }
}

