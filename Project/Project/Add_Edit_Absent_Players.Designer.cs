namespace Project
{
    partial class Add_Edit_Absent_Players
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
            this.Check_Absent = new System.Windows.Forms.CheckedListBox();
            this.Training_Label = new System.Windows.Forms.Label();
            this.Training_CB = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Check_Absent
            // 
            this.Check_Absent.FormattingEnabled = true;
            this.Check_Absent.Location = new System.Drawing.Point(21, 51);
            this.Check_Absent.Name = "Check_Absent";
            this.Check_Absent.Size = new System.Drawing.Size(236, 169);
            this.Check_Absent.TabIndex = 0;
            // 
            // Training_Label
            // 
            this.Training_Label.AutoSize = true;
            this.Training_Label.Location = new System.Drawing.Point(18, 16);
            this.Training_Label.Name = "Training_Label";
            this.Training_Label.Size = new System.Drawing.Size(45, 13);
            this.Training_Label.TabIndex = 1;
            this.Training_Label.Text = "Training";
            // 
            // Training_CB
            // 
            this.Training_CB.FormattingEnabled = true;
            this.Training_CB.Location = new System.Drawing.Point(103, 13);
            this.Training_CB.Name = "Training_CB";
            this.Training_CB.Size = new System.Drawing.Size(154, 21);
            this.Training_CB.TabIndex = 2;
            this.Training_CB.SelectedIndexChanged += new System.EventHandler(this.Training_CB_SelectedIndexChanged);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(184, 230);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 24;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(103, 230);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 23;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add_Edit_Absent_Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 265);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Training_CB);
            this.Controls.Add(this.Training_Label);
            this.Controls.Add(this.Check_Absent);
            this.Name = "Add_Edit_Absent_Players";
            this.Text = "Add_Edit_Absent_Players";
            this.Load += new System.EventHandler(this.Add_Edit_Absent_Players_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Check_Absent;
        private System.Windows.Forms.Label Training_Label;
        private System.Windows.Forms.ComboBox Training_CB;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Save;
    }
}