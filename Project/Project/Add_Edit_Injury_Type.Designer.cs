namespace Project
{
    partial class Add_Edit_Injury_Type
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
            this.IDCB = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Describtion_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.Describtion_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDCB
            // 
            this.IDCB.FormattingEnabled = true;
            this.IDCB.Items.AddRange(new object[] {
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
            this.IDCB.Location = new System.Drawing.Point(103, 28);
            this.IDCB.Name = "IDCB";
            this.IDCB.Size = new System.Drawing.Size(121, 21);
            this.IDCB.TabIndex = 25;
            this.IDCB.SelectedIndexChanged += new System.EventHandler(this.IDCB_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(36, 172);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(198, 172);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(117, 172);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 21;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(103, 71);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(121, 20);
            this.Name_Text.TabIndex = 20;
            this.Name_Text.TextChanged += new System.EventHandler(this.Name_Text_TextChanged);
            // 
            // Describtion_Label
            // 
            this.Describtion_Label.AutoSize = true;
            this.Describtion_Label.Location = new System.Drawing.Point(12, 117);
            this.Describtion_Label.Name = "Describtion_Label";
            this.Describtion_Label.Size = new System.Drawing.Size(60, 13);
            this.Describtion_Label.TabIndex = 19;
            this.Describtion_Label.Text = "Describtion";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(12, 74);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Name_Label.TabIndex = 18;
            this.Name_Label.Text = "Name";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(12, 31);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(18, 13);
            this.ID_Label.TabIndex = 17;
            this.ID_Label.Text = "ID";
            // 
            // Describtion_Text
            // 
            this.Describtion_Text.Location = new System.Drawing.Point(103, 110);
            this.Describtion_Text.Name = "Describtion_Text";
            this.Describtion_Text.Size = new System.Drawing.Size(121, 20);
            this.Describtion_Text.TabIndex = 26;
            // 
            // Add_Edit_Injury_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.Describtion_Text);
            this.Controls.Add(this.IDCB);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Describtion_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.ID_Label);
            this.Name = "Add_Edit_Injury_Type";
            this.Text = "Add_Edit_Injury_Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IDCB;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Label Describtion_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.TextBox Describtion_Text;
    }
}