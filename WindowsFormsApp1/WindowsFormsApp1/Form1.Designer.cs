namespace WindowsFormsApp1
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
            this.register = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.email_log = new System.Windows.Forms.TextBox();
            this.password_log = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(32, 359);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(100, 41);
            this.register.TabIndex = 0;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(479, 359);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(105, 42);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(32, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 2;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(32, 106);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 26);
            this.surname.TabIndex = 3;
            // 
            // email_log
            // 
            this.email_log.Location = new System.Drawing.Point(479, 44);
            this.email_log.Name = "email_log";
            this.email_log.Size = new System.Drawing.Size(100, 26);
            this.email_log.TabIndex = 4;
            // 
            // password_log
            // 
            this.password_log.Location = new System.Drawing.Point(479, 106);
            this.password_log.Name = "password_log";
            this.password_log.Size = new System.Drawing.Size(100, 26);
            this.password_log.TabIndex = 5;
            // 
            // confirmpassword
            // 
            this.confirmpassword.Location = new System.Drawing.Point(178, 220);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(100, 26);
            this.confirmpassword.TabIndex = 6;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(32, 220);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 26);
            this.password.TabIndex = 7;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(32, 164);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 26);
            this.email.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 281);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "voter";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(205, 281);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "participator";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "upload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.password_log);
            this.Controls.Add(this.email_log);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.login);
            this.Controls.Add(this.register);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox email_log;
        private System.Windows.Forms.TextBox password_log;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}

