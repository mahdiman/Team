namespace Project
{
    partial class User_History
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
            this.History = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.Delete_Record = new System.Windows.Forms.Button();
            this.Delete_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.History)).BeginInit();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.AllowUserToAddRows = false;
            this.History.AllowUserToDeleteRows = false;
            this.History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.History.Location = new System.Drawing.Point(12, 12);
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.Size = new System.Drawing.Size(534, 483);
            this.History.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(471, 502);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Delete_Record
            // 
            this.Delete_Record.Location = new System.Drawing.Point(373, 502);
            this.Delete_Record.Name = "Delete_Record";
            this.Delete_Record.Size = new System.Drawing.Size(92, 23);
            this.Delete_Record.TabIndex = 2;
            this.Delete_Record.Text = "Delete Record";
            this.Delete_Record.UseVisualStyleBackColor = true;
            this.Delete_Record.Click += new System.EventHandler(this.Delete_Record_Click);
            // 
            // Delete_All
            // 
            this.Delete_All.Location = new System.Drawing.Point(292, 502);
            this.Delete_All.Name = "Delete_All";
            this.Delete_All.Size = new System.Drawing.Size(75, 23);
            this.Delete_All.TabIndex = 3;
            this.Delete_All.Text = "Delete All";
            this.Delete_All.UseVisualStyleBackColor = true;
            this.Delete_All.Click += new System.EventHandler(this.Delete_All_Click);
            // 
            // User_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 536);
            this.Controls.Add(this.Delete_All);
            this.Controls.Add(this.Delete_Record);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.History);
            this.Name = "User_History";
            this.Text = "User History";
            this.Load += new System.EventHandler(this.User_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.History)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView History;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Delete_Record;
        private System.Windows.Forms.Button Delete_All;
    }
}