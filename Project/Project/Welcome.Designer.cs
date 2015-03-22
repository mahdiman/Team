namespace Project
{
    partial class Welcome
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
            this.Login_Button = new System.Windows.Forms.Button();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.Pass_Word = new System.Windows.Forms.TextBox();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.Enabled = false;
            this.Login_Button.Location = new System.Drawing.Point(75, 211);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 0;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // User_Name
            // 
            this.User_Name.Location = new System.Drawing.Point(84, 33);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(129, 20);
            this.User_Name.TabIndex = 1;
            this.User_Name.TextChanged += new System.EventHandler(this.User_Name_TextChanged);
            // 
            // Pass_Word
            // 
            this.Pass_Word.Location = new System.Drawing.Point(84, 84);
            this.Pass_Word.MaxLength = 16;
            this.Pass_Word.Name = "Pass_Word";
            this.Pass_Word.PasswordChar = '*';
            this.Pass_Word.Size = new System.Drawing.Size(129, 20);
            this.Pass_Word.TabIndex = 2;
            this.Pass_Word.TextChanged += new System.EventHandler(this.Pass_Word_TextChanged);
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(6, 36);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(41, 13);
            this.Username_Label.TabIndex = 3;
            this.Username_Label.Text = "Handle";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(6, 87);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Password_Label.TabIndex = 4;
            this.Password_Label.Text = "Password";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(232, 211);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pass_Word);
            this.groupBox1.Controls.Add(this.User_Name);
            this.groupBox1.Controls.Add(this.Password_Label);
            this.groupBox1.Controls.Add(this.Username_Label);
            this.groupBox1.Location = new System.Drawing.Point(75, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SignIn";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 275);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Login_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.TextBox Pass_Word;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

