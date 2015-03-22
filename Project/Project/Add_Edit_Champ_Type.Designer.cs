namespace Project
{
    partial class Add_Edit_Champ_Type
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
            this.ID_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Type_Label = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Type_CB = new System.Windows.Forms.ComboBox();
            this.IDCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(12, 30);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(18, 13);
            this.ID_Label.TabIndex = 0;
            this.ID_Label.Text = "ID";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(12, 73);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "Name";
            // 
            // Type_Label
            // 
            this.Type_Label.AutoSize = true;
            this.Type_Label.Location = new System.Drawing.Point(12, 116);
            this.Type_Label.Name = "Type_Label";
            this.Type_Label.Size = new System.Drawing.Size(31, 13);
            this.Type_Label.TabIndex = 2;
            this.Type_Label.Text = "Type";
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(103, 70);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(121, 20);
            this.Name_Text.TabIndex = 5;
            this.Name_Text.TextChanged += new System.EventHandler(this.Name_Text_TextChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(36, 171);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(198, 171);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(117, 171);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Type_CB
            // 
            this.Type_CB.FormattingEnabled = true;
            this.Type_CB.Items.AddRange(new object[] {
            "Cup",
            "League"});
            this.Type_CB.Location = new System.Drawing.Point(103, 113);
            this.Type_CB.Name = "Type_CB";
            this.Type_CB.Size = new System.Drawing.Size(121, 21);
            this.Type_CB.TabIndex = 15;
            this.Type_CB.SelectedIndexChanged += new System.EventHandler(this.Type_CB_SelectedIndexChanged);
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
            this.IDCB.Location = new System.Drawing.Point(103, 27);
            this.IDCB.Name = "IDCB";
            this.IDCB.Size = new System.Drawing.Size(121, 21);
            this.IDCB.TabIndex = 16;
            this.IDCB.SelectedIndexChanged += new System.EventHandler(this.IDCB_SelectedIndexChanged);
            // 
            // Add_Edit_Champ_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.IDCB);
            this.Controls.Add(this.Type_CB);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Type_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.ID_Label);
            this.Name = "Add_Edit_Champ_Type";
            this.Text = "Add_Edit_Champ_Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Type_Label;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox Type_CB;
        private System.Windows.Forms.ComboBox IDCB;
    }
}