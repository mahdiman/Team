namespace Project
{
    partial class Add_Edit_Match
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
            this.Our_Goals_Label = new System.Windows.Forms.Label();
            this.Opponent_Label = new System.Windows.Forms.Label();
            this.Competition_Label = new System.Windows.Forms.Label();
            this.Staduim_Label = new System.Windows.Forms.Label();
            this.Opponent_Goals_Label = new System.Windows.Forms.Label();
            this.Our_Goals_CB = new System.Windows.Forms.ComboBox();
            this.Opponent_Goals_CB = new System.Windows.Forms.ComboBox();
            this.Staduim_Text = new System.Windows.Forms.TextBox();
            this.Opponent_Text = new System.Windows.Forms.TextBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Delete_Match_Button = new System.Windows.Forms.Button();
            this.Save_Add_Edit_Button = new System.Windows.Forms.Button();
            this.Comp_ID_CB = new System.Windows.Forms.ComboBox();
            this.Star_Date = new System.Windows.Forms.Label();
            this.Start_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Our_Goals_Label
            // 
            this.Our_Goals_Label.AutoSize = true;
            this.Our_Goals_Label.Location = new System.Drawing.Point(23, 204);
            this.Our_Goals_Label.Name = "Our_Goals_Label";
            this.Our_Goals_Label.Size = new System.Drawing.Size(54, 13);
            this.Our_Goals_Label.TabIndex = 5;
            this.Our_Goals_Label.Text = "Our Goals";
            // 
            // Opponent_Label
            // 
            this.Opponent_Label.AutoSize = true;
            this.Opponent_Label.Location = new System.Drawing.Point(23, 70);
            this.Opponent_Label.Name = "Opponent_Label";
            this.Opponent_Label.Size = new System.Drawing.Size(54, 13);
            this.Opponent_Label.TabIndex = 6;
            this.Opponent_Label.Text = "Opponent";
            // 
            // Competition_Label
            // 
            this.Competition_Label.AutoSize = true;
            this.Competition_Label.Location = new System.Drawing.Point(23, 114);
            this.Competition_Label.Name = "Competition_Label";
            this.Competition_Label.Size = new System.Drawing.Size(62, 13);
            this.Competition_Label.TabIndex = 7;
            this.Competition_Label.Text = "Competition";
            // 
            // Staduim_Label
            // 
            this.Staduim_Label.AutoSize = true;
            this.Staduim_Label.Location = new System.Drawing.Point(23, 154);
            this.Staduim_Label.Name = "Staduim_Label";
            this.Staduim_Label.Size = new System.Drawing.Size(45, 13);
            this.Staduim_Label.TabIndex = 8;
            this.Staduim_Label.Text = "Staduim";
            // 
            // Opponent_Goals_Label
            // 
            this.Opponent_Goals_Label.AutoSize = true;
            this.Opponent_Goals_Label.Location = new System.Drawing.Point(147, 204);
            this.Opponent_Goals_Label.Name = "Opponent_Goals_Label";
            this.Opponent_Goals_Label.Size = new System.Drawing.Size(84, 13);
            this.Opponent_Goals_Label.TabIndex = 9;
            this.Opponent_Goals_Label.Text = "Opponent Goals";
            // 
            // Our_Goals_CB
            // 
            this.Our_Goals_CB.FormattingEnabled = true;
            this.Our_Goals_CB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.Our_Goals_CB.Location = new System.Drawing.Point(26, 233);
            this.Our_Goals_CB.Name = "Our_Goals_CB";
            this.Our_Goals_CB.Size = new System.Drawing.Size(63, 21);
            this.Our_Goals_CB.TabIndex = 13;
            // 
            // Opponent_Goals_CB
            // 
            this.Opponent_Goals_CB.FormattingEnabled = true;
            this.Opponent_Goals_CB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.Opponent_Goals_CB.Location = new System.Drawing.Point(150, 233);
            this.Opponent_Goals_CB.Name = "Opponent_Goals_CB";
            this.Opponent_Goals_CB.Size = new System.Drawing.Size(63, 21);
            this.Opponent_Goals_CB.TabIndex = 17;
            // 
            // Staduim_Text
            // 
            this.Staduim_Text.Location = new System.Drawing.Point(125, 151);
            this.Staduim_Text.Name = "Staduim_Text";
            this.Staduim_Text.Size = new System.Drawing.Size(121, 20);
            this.Staduim_Text.TabIndex = 18;
            this.Staduim_Text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Opponent_Text
            // 
            this.Opponent_Text.Location = new System.Drawing.Point(125, 67);
            this.Opponent_Text.Name = "Opponent_Text";
            this.Opponent_Text.Size = new System.Drawing.Size(121, 20);
            this.Opponent_Text.TabIndex = 20;
            this.Opponent_Text.TextChanged += new System.EventHandler(this.Opponent_Text_TextChanged);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(218, 305);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 21;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Delete_Match_Button
            // 
            this.Delete_Match_Button.Location = new System.Drawing.Point(34, 305);
            this.Delete_Match_Button.Name = "Delete_Match_Button";
            this.Delete_Match_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Match_Button.TabIndex = 22;
            this.Delete_Match_Button.Text = "Delete Match";
            this.Delete_Match_Button.UseVisualStyleBackColor = true;
            this.Delete_Match_Button.Click += new System.EventHandler(this.Delete_Match_Button_Click);
            // 
            // Save_Add_Edit_Button
            // 
            this.Save_Add_Edit_Button.Enabled = false;
            this.Save_Add_Edit_Button.Location = new System.Drawing.Point(126, 305);
            this.Save_Add_Edit_Button.Name = "Save_Add_Edit_Button";
            this.Save_Add_Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Add_Edit_Button.TabIndex = 23;
            this.Save_Add_Edit_Button.Text = "Save";
            this.Save_Add_Edit_Button.UseVisualStyleBackColor = true;
            this.Save_Add_Edit_Button.Click += new System.EventHandler(this.Save_Add_Edit_Button_Click);
            // 
            // Comp_ID_CB
            // 
            this.Comp_ID_CB.FormattingEnabled = true;
            this.Comp_ID_CB.Location = new System.Drawing.Point(125, 111);
            this.Comp_ID_CB.Name = "Comp_ID_CB";
            this.Comp_ID_CB.Size = new System.Drawing.Size(121, 21);
            this.Comp_ID_CB.TabIndex = 24;
            // 
            // Star_Date
            // 
            this.Star_Date.AutoSize = true;
            this.Star_Date.Location = new System.Drawing.Point(23, 20);
            this.Star_Date.Name = "Star_Date";
            this.Star_Date.Size = new System.Drawing.Size(55, 13);
            this.Star_Date.TabIndex = 66;
            this.Star_Date.Text = "Start Date";
            // 
            // Start_Date_Picker
            // 
            this.Start_Date_Picker.CustomFormat = "MM-dd-yyyy HH:mm:ss";
            this.Start_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start_Date_Picker.Location = new System.Drawing.Point(125, 20);
            this.Start_Date_Picker.Name = "Start_Date_Picker";
            this.Start_Date_Picker.Size = new System.Drawing.Size(121, 20);
            this.Start_Date_Picker.TabIndex = 65;
            this.Start_Date_Picker.ValueChanged += new System.EventHandler(this.Start_Date_Picker_ValueChanged);
            // 
            // Add_Edit_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 352);
            this.Controls.Add(this.Star_Date);
            this.Controls.Add(this.Start_Date_Picker);
            this.Controls.Add(this.Comp_ID_CB);
            this.Controls.Add(this.Save_Add_Edit_Button);
            this.Controls.Add(this.Delete_Match_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Opponent_Text);
            this.Controls.Add(this.Staduim_Text);
            this.Controls.Add(this.Opponent_Goals_CB);
            this.Controls.Add(this.Our_Goals_CB);
            this.Controls.Add(this.Opponent_Goals_Label);
            this.Controls.Add(this.Staduim_Label);
            this.Controls.Add(this.Competition_Label);
            this.Controls.Add(this.Opponent_Label);
            this.Controls.Add(this.Our_Goals_Label);
            this.Name = "Add_Edit_Match";
            this.Text = "Add_Edit_Match";
            this.Load += new System.EventHandler(this.Add_Edit_Match_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Our_Goals_Label;
        private System.Windows.Forms.Label Opponent_Label;
        private System.Windows.Forms.Label Competition_Label;
        private System.Windows.Forms.Label Staduim_Label;
        private System.Windows.Forms.Label Opponent_Goals_Label;
        private System.Windows.Forms.ComboBox Our_Goals_CB;
        private System.Windows.Forms.ComboBox Opponent_Goals_CB;
        private System.Windows.Forms.TextBox Staduim_Text;
        private System.Windows.Forms.TextBox Opponent_Text;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Delete_Match_Button;
        private System.Windows.Forms.Button Save_Add_Edit_Button;
        private System.Windows.Forms.ComboBox Comp_ID_CB;
        private System.Windows.Forms.Label Star_Date;
        private System.Windows.Forms.DateTimePicker Start_Date_Picker;

    }
}