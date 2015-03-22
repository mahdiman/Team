namespace Project
{
    partial class Add_Edit_Jobs
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
            this.Job_ID = new System.Windows.Forms.Label();
            this.Job_Name = new System.Windows.Forms.Label();
            this.Job_Describtion = new System.Windows.Forms.Label();
            this.Mngr_Job_ID = new System.Windows.Forms.Label();
            this.JobNameText = new System.Windows.Forms.TextBox();
            this.JobDescribtionText = new System.Windows.Forms.TextBox();
            this.IDCB = new System.Windows.Forms.ComboBox();
            this.MngrIDCB = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Job_ID
            // 
            this.Job_ID.AutoSize = true;
            this.Job_ID.Location = new System.Drawing.Point(33, 37);
            this.Job_ID.Name = "Job_ID";
            this.Job_ID.Size = new System.Drawing.Size(18, 13);
            this.Job_ID.TabIndex = 0;
            this.Job_ID.Text = "ID";
            // 
            // Job_Name
            // 
            this.Job_Name.AutoSize = true;
            this.Job_Name.Location = new System.Drawing.Point(33, 78);
            this.Job_Name.Name = "Job_Name";
            this.Job_Name.Size = new System.Drawing.Size(35, 13);
            this.Job_Name.TabIndex = 1;
            this.Job_Name.Text = "Name";
            // 
            // Job_Describtion
            // 
            this.Job_Describtion.AutoSize = true;
            this.Job_Describtion.Location = new System.Drawing.Point(33, 120);
            this.Job_Describtion.Name = "Job_Describtion";
            this.Job_Describtion.Size = new System.Drawing.Size(60, 13);
            this.Job_Describtion.TabIndex = 2;
            this.Job_Describtion.Text = "Describtion";
            // 
            // Mngr_Job_ID
            // 
            this.Mngr_Job_ID.AutoSize = true;
            this.Mngr_Job_ID.Location = new System.Drawing.Point(33, 159);
            this.Mngr_Job_ID.Name = "Mngr_Job_ID";
            this.Mngr_Job_ID.Size = new System.Drawing.Size(63, 13);
            this.Mngr_Job_ID.TabIndex = 3;
            this.Mngr_Job_ID.Text = "Manager ID";
            // 
            // JobNameText
            // 
            this.JobNameText.Location = new System.Drawing.Point(172, 75);
            this.JobNameText.Name = "JobNameText";
            this.JobNameText.Size = new System.Drawing.Size(100, 20);
            this.JobNameText.TabIndex = 4;
            this.JobNameText.TextChanged += new System.EventHandler(this.JobNameText_TextChanged);
            // 
            // JobDescribtionText
            // 
            this.JobDescribtionText.Location = new System.Drawing.Point(172, 117);
            this.JobDescribtionText.Name = "JobDescribtionText";
            this.JobDescribtionText.Size = new System.Drawing.Size(100, 20);
            this.JobDescribtionText.TabIndex = 5;
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
            this.IDCB.Location = new System.Drawing.Point(172, 29);
            this.IDCB.Name = "IDCB";
            this.IDCB.Size = new System.Drawing.Size(100, 21);
            this.IDCB.TabIndex = 6;
            this.IDCB.SelectedIndexChanged += new System.EventHandler(this.IDCB_SelectedIndexChanged);
            // 
            // MngrIDCB
            // 
            this.MngrIDCB.FormattingEnabled = true;
            this.MngrIDCB.Location = new System.Drawing.Point(172, 156);
            this.MngrIDCB.Name = "MngrIDCB";
            this.MngrIDCB.Size = new System.Drawing.Size(100, 21);
            this.MngrIDCB.TabIndex = 7;
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(160, 219);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(241, 219);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(79, 219);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add_Edit_Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 274);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.MngrIDCB);
            this.Controls.Add(this.IDCB);
            this.Controls.Add(this.JobDescribtionText);
            this.Controls.Add(this.JobNameText);
            this.Controls.Add(this.Mngr_Job_ID);
            this.Controls.Add(this.Job_Describtion);
            this.Controls.Add(this.Job_Name);
            this.Controls.Add(this.Job_ID);
            this.Name = "Add_Edit_Jobs";
            this.Text = "Add_Edit_Jobs";
            this.Load += new System.EventHandler(this.Add_Edit_Jobs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Job_ID;
        private System.Windows.Forms.Label Job_Name;
        private System.Windows.Forms.Label Job_Describtion;
        private System.Windows.Forms.Label Mngr_Job_ID;
        private System.Windows.Forms.TextBox JobNameText;
        private System.Windows.Forms.TextBox JobDescribtionText;
        private System.Windows.Forms.ComboBox IDCB;
        private System.Windows.Forms.ComboBox MngrIDCB;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Delete;
    }
}