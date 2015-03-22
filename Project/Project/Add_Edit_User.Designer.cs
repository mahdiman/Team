namespace Project
{
    partial class Add_Edit_User
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
            this.Handle_Label = new System.Windows.Forms.Label();
            this.PrivilegesLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PassWord_Label = new System.Windows.Forms.Label();
            this.HandleText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PassWordText = new System.Windows.Forms.TextBox();
            this.PrivilegesCB = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Handle_Label
            // 
            this.Handle_Label.AutoSize = true;
            this.Handle_Label.Location = new System.Drawing.Point(12, 26);
            this.Handle_Label.Name = "Handle_Label";
            this.Handle_Label.Size = new System.Drawing.Size(41, 13);
            this.Handle_Label.TabIndex = 0;
            this.Handle_Label.Text = "Handle";
            // 
            // PrivilegesLabel
            // 
            this.PrivilegesLabel.AutoSize = true;
            this.PrivilegesLabel.Location = new System.Drawing.Point(12, 166);
            this.PrivilegesLabel.Name = "PrivilegesLabel";
            this.PrivilegesLabel.Size = new System.Drawing.Size(52, 13);
            this.PrivilegesLabel.TabIndex = 1;
            this.PrivilegesLabel.Text = "Privileges";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 119);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // PassWord_Label
            // 
            this.PassWord_Label.AutoSize = true;
            this.PassWord_Label.Location = new System.Drawing.Point(12, 73);
            this.PassWord_Label.Name = "PassWord_Label";
            this.PassWord_Label.Size = new System.Drawing.Size(53, 13);
            this.PassWord_Label.TabIndex = 3;
            this.PassWord_Label.Text = "Password";
            // 
            // HandleText
            // 
            this.HandleText.Location = new System.Drawing.Point(89, 23);
            this.HandleText.Name = "HandleText";
            this.HandleText.Size = new System.Drawing.Size(100, 20);
            this.HandleText.TabIndex = 4;
            this.HandleText.TextChanged += new System.EventHandler(this.HandleText_TextChanged);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(89, 116);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 6;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // PassWordText
            // 
            this.PassWordText.Location = new System.Drawing.Point(89, 70);
            this.PassWordText.Name = "PassWordText";
            this.PassWordText.Size = new System.Drawing.Size(100, 20);
            this.PassWordText.TabIndex = 7;
            this.PassWordText.TextChanged += new System.EventHandler(this.PassWordText_TextChanged);
            // 
            // PrivilegesCB
            // 
            this.PrivilegesCB.FormattingEnabled = true;
            this.PrivilegesCB.Items.AddRange(new object[] {
            "Admin",
            "Add Employee",
            "Edit Employee",
            "Trainer",
            "Doctor",
            "Manager"});
            this.PrivilegesCB.Location = new System.Drawing.Point(89, 163);
            this.PrivilegesCB.Name = "PrivilegesCB";
            this.PrivilegesCB.Size = new System.Drawing.Size(100, 21);
            this.PrivilegesCB.TabIndex = 8;
            this.PrivilegesCB.SelectedIndexChanged += new System.EventHandler(this.PrivilegesCB_SelectedIndexChanged);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(177, 233);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(96, 233);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(15, 233);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Check
            // 
            this.Check.AutoSize = true;
            this.Check.Location = new System.Drawing.Point(205, 26);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(0, 13);
            this.Check.TabIndex = 12;
            // 
            // Add_Edit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 279);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PrivilegesCB);
            this.Controls.Add(this.PassWordText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.HandleText);
            this.Controls.Add(this.PassWord_Label);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PrivilegesLabel);
            this.Controls.Add(this.Handle_Label);
            this.Name = "Add_Edit_User";
            this.Text = "Add_Edit_User";
            this.Load += new System.EventHandler(this.Add_Edit_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Handle_Label;
        private System.Windows.Forms.Label PrivilegesLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PassWord_Label;
        private System.Windows.Forms.TextBox HandleText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PassWordText;
        private System.Windows.Forms.ComboBox PrivilegesCB;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Check;
    }
}