namespace sprint_2_draft
{
    partial class DeactivateEmployee
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.Employee_ID = new System.Windows.Forms.Label();
            this.Previous_Screen = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.textBox2.Location = new System.Drawing.Point(336, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 17;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(221, 122);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 16;
            this.LastName.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.textBox1.Location = new System.Drawing.Point(336, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 15;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(221, 84);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 14;
            this.FirstName.Text = "First Name";
            // 
            // textBox10
            // 
            this.textBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.textBox10.Location = new System.Drawing.Point(336, 45);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(123, 20);
            this.textBox10.TabIndex = 13;
            // 
            // Employee_ID
            // 
            this.Employee_ID.AutoSize = true;
            this.Employee_ID.Location = new System.Drawing.Point(221, 45);
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Size = new System.Drawing.Size(67, 13);
            this.Employee_ID.TabIndex = 12;
            this.Employee_ID.Text = "Employee ID";
            // 
            // Previous_Screen
            // 
            this.Previous_Screen.Location = new System.Drawing.Point(64, 239);
            this.Previous_Screen.Name = "Previous_Screen";
            this.Previous_Screen.Size = new System.Drawing.Size(106, 34);
            this.Previous_Screen.TabIndex = 27;
            this.Previous_Screen.Text = "Previous Screen";
            this.Previous_Screen.UseVisualStyleBackColor = true;
            this.Previous_Screen.Click += new System.EventHandler(this.Previous_Screen_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(393, 239);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(66, 34);
            this.Exit.TabIndex = 26;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(224, 249);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Deactivate Employee";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DeactivateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 318);
            this.Controls.Add(this.Previous_Screen);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.Employee_ID);
            this.Name = "DeactivateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeactivateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label Employee_ID;
        private System.Windows.Forms.Button Previous_Screen;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}