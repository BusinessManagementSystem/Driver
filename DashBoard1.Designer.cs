namespace sprint_2_draft
{
    partial class DashBoard1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Employee_Count_by_Age = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollSystemDataSet = new sprint_2_draft.PayrollSystemDataSet();
            this.Dashboard_System = new System.Windows.Forms.Label();
            this.DSS1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DSS3 = new System.Windows.Forms.Button();
            this.DSS2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Previous_Screen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new sprint_2_draft.PayrollSystemDataSetTableAdapters.EmployeeTableAdapter();
            this.circularprogressbar1 = new sprint_2_draft.Circularprogressbar();
            this.Highest_earners = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Count_by_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employee_Count_by_Age
            // 
            chartArea6.Name = "Employee Count By Age";
            this.Employee_Count_by_Age.ChartAreas.Add(chartArea6);
            this.Employee_Count_by_Age.DataSource = this.employeeBindingSource;
            legend6.Name = "Legend1";
            this.Employee_Count_by_Age.Legends.Add(legend6);
            this.Employee_Count_by_Age.Location = new System.Drawing.Point(290, 52);
            this.Employee_Count_by_Age.Name = "Employee_Count_by_Age";
            series6.ChartArea = "Employee Count By Age";
            series6.Legend = "Legend1";
            series6.MarkerColor = System.Drawing.Color.Yellow;
            series6.Name = "Employee Earning";
            series6.XValueMember = "firstname";
            series6.YValueMembers = "Earningsalary";
            series6.YValuesPerPoint = 3;
            this.Employee_Count_by_Age.Series.Add(series6);
            this.Employee_Count_by_Age.Size = new System.Drawing.Size(376, 269);
            this.Employee_Count_by_Age.TabIndex = 17;
            this.Employee_Count_by_Age.Text = "Employee By Earning";
            this.Employee_Count_by_Age.Click += new System.EventHandler(this.Employee_Count_by_Age_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.payrollSystemDataSet;
            // 
            // payrollSystemDataSet
            // 
            this.payrollSystemDataSet.DataSetName = "PayrollSystemDataSet";
            this.payrollSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dashboard_System
            // 
            this.Dashboard_System.AutoSize = true;
            this.Dashboard_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_System.Location = new System.Drawing.Point(-3, 38);
            this.Dashboard_System.Name = "Dashboard_System";
            this.Dashboard_System.Size = new System.Drawing.Size(263, 33);
            this.Dashboard_System.TabIndex = 14;
            this.Dashboard_System.Text = "Dashboard System";
            // 
            // DSS1
            // 
            this.DSS1.Location = new System.Drawing.Point(26, 135);
            this.DSS1.Name = "DSS1";
            this.DSS1.Size = new System.Drawing.Size(215, 99);
            this.DSS1.TabIndex = 17;
            this.DSS1.Text = "DSS1";
            this.DSS1.UseVisualStyleBackColor = true;
            this.DSS1.Click += new System.EventHandler(this.DSS1_Click);
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
            this.panel1.Size = new System.Drawing.Size(260, 542);
            this.panel1.TabIndex = 16;
            // 
            // DSS3
            // 
            this.DSS3.Location = new System.Drawing.Point(26, 386);
            this.DSS3.Name = "DSS3";
            this.DSS3.Size = new System.Drawing.Size(215, 95);
            this.DSS3.TabIndex = 15;
            this.DSS3.Text = "DSS3";
            this.DSS3.UseVisualStyleBackColor = true;
            this.DSS3.Click += new System.EventHandler(this.DSS3_Click);
            // 
            // DSS2
            // 
            this.DSS2.Location = new System.Drawing.Point(26, 257);
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
            this.panel3.Size = new System.Drawing.Size(260, 103);
            this.panel3.TabIndex = 13;
            // 
            // Previous_Screen
            // 
            this.Previous_Screen.Location = new System.Drawing.Point(26, 496);
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
            this.button1.Location = new System.Drawing.Point(169, 496);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // circularprogressbar1
            // 
            this.circularprogressbar1.Location = new System.Drawing.Point(694, 52);
            this.circularprogressbar1.Name = "circularprogressbar1";
            this.circularprogressbar1.Size = new System.Drawing.Size(247, 269);
            this.circularprogressbar1.TabIndex = 18;
            // 
            // Highest_earners
            // 
            this.Highest_earners.AutoSize = true;
            this.Highest_earners.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highest_earners.Location = new System.Drawing.Point(684, 324);
            this.Highest_earners.Name = "Highest_earners";
            this.Highest_earners.Size = new System.Drawing.Size(257, 25);
            this.Highest_earners.TabIndex = 19;
            this.Highest_earners.Text = "Shows Highest Earners";
            // 
            // DashBoard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 542);
            this.Controls.Add(this.Highest_earners);
            this.Controls.Add(this.circularprogressbar1);
            this.Controls.Add(this.Employee_Count_by_Age);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard1";
            this.Text = "DashBoard1";
            this.Load += new System.EventHandler(this.DashBoard1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Count_by_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Employee_Count_by_Age;
        private System.Windows.Forms.Label Dashboard_System;
        private System.Windows.Forms.Button DSS1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DSS3;
        private System.Windows.Forms.Button DSS2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Previous_Screen;
        private System.Windows.Forms.Button button1;
        private PayrollSystemDataSet payrollSystemDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PayrollSystemDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private Circularprogressbar circularprogressbar1;
        private System.Windows.Forms.Label Highest_earners;
    }
}