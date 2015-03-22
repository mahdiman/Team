namespace Project
{
    partial class Player_Performance_Menu
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
            this.PerformanceListView = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceListView)).BeginInit();
            this.SuspendLayout();
            // 
            // PerformanceListView
            // 
            this.PerformanceListView.AllowUserToAddRows = false;
            this.PerformanceListView.AllowUserToDeleteRows = false;
            this.PerformanceListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerformanceListView.Location = new System.Drawing.Point(12, 12);
            this.PerformanceListView.Name = "PerformanceListView";
            this.PerformanceListView.ReadOnly = true;
            this.PerformanceListView.Size = new System.Drawing.Size(453, 310);
            this.PerformanceListView.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(390, 342);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(228, 342);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(309, 342);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Player_Performance_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 375);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PerformanceListView);
            this.Name = "Player_Performance_Menu";
            this.Text = "Player_Performance_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PerformanceListView;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;

    }
}