namespace sprint_2_draft
{
    partial class Login_Page
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Register_Here = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Previous_page = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(167, 67);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(98, 20);
            this.Username.TabIndex = 2;
            this.Username.Text = "UserName:";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(167, 132);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(91, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(143, 240);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(103, 63);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(274, 240);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(103, 63);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register_Here
            // 
            this.Register_Here.AutoSize = true;
            this.Register_Here.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Here.Location = new System.Drawing.Point(43, 201);
            this.Register_Here.Name = "Register_Here";
            this.Register_Here.Size = new System.Drawing.Size(275, 20);
            this.Register_Here.TabIndex = 7;
            this.Register_Here.TabStop = true;
            this.Register_Here.Text = "Don\'t have an account, Register Here";
            this.Register_Here.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_Here_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 326);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = global::sprint_2_draft.Properties.Resources.secrecy_icon;
            this.pictureBox2.Location = new System.Drawing.Point(48, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Previous_page
            // 
            this.Previous_page.Location = new System.Drawing.Point(402, 240);
            this.Previous_page.Name = "Previous_page";
            this.Previous_page.Size = new System.Drawing.Size(103, 63);
            this.Previous_page.TabIndex = 10;
            this.Previous_page.Text = "Back to Previous page";
            this.Previous_page.UseVisualStyleBackColor = true;
            this.Previous_page.Click += new System.EventHandler(this.Previous_page_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sprint_2_draft.Properties.Resources._4afc00bb3d1edb879baaae0ef27192382;
            this.ClientSize = new System.Drawing.Size(635, 364);
            this.Controls.Add(this.Previous_page);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Register_Here);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.LinkLabel Register_Here;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Previous_page;
    }
}