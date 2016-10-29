namespace sprint_2_draft
{
    partial class Splash_Screen
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
            this.DashBoard_Payroll_System = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DashBoard_Payroll_System
            // 
            this.DashBoard_Payroll_System.AutoSize = true;
            this.DashBoard_Payroll_System.BackColor = System.Drawing.Color.Transparent;
            this.DashBoard_Payroll_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard_Payroll_System.Location = new System.Drawing.Point(12, 81);
            this.DashBoard_Payroll_System.Name = "DashBoard_Payroll_System";
            this.DashBoard_Payroll_System.Size = new System.Drawing.Size(438, 31);
            this.DashBoard_Payroll_System.TabIndex = 1;
            this.DashBoard_Payroll_System.Text = "DashBoard For a Payroll System";
            this.DashBoard_Payroll_System.Click += new System.EventHandler(this.label1_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(168, 139);
            this.Enter.Margin = new System.Windows.Forms.Padding(2);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(99, 43);
            this.Enter.TabIndex = 8;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click_1);
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sprint_2_draft.Properties.Resources.tumblr_static_tumblr_static_co864q8w91s8kc8okcwgwssog_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.DashBoard_Payroll_System);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Screen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_Screen";
            this.Load += new System.EventHandler(this.Splash_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DashBoard_Payroll_System;
        private System.Windows.Forms.Button Enter;
        
    }
}