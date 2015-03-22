namespace Project
{
    partial class Add_Edit_Sponsor
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
            this.ContactAgent_Text = new System.Windows.Forms.TextBox();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.E_Mail_Text = new System.Windows.Forms.TextBox();
            this.Address_Text = new System.Windows.Forms.TextBox();
            this.ContactAgentID_Label = new System.Windows.Forms.Label();
            this.CompanyName_Label = new System.Windows.Forms.Label();
            this.E_Mail_Label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.OurAgent_CB = new System.Windows.Forms.ComboBox();
            this.OurAgentID_Label = new System.Windows.Forms.Label();
            this.Activity_Text = new System.Windows.Forms.TextBox();
            this.Actitvity_Label = new System.Windows.Forms.Label();
            this.companyIDCB = new System.Windows.Forms.ComboBox();
            this.Company_ID_Label = new System.Windows.Forms.Label();
            this.Delete_Company = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Save_Add_Edit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContactAgent_Text
            // 
            this.ContactAgent_Text.Location = new System.Drawing.Point(108, 195);
            this.ContactAgent_Text.MaxLength = 12;
            this.ContactAgent_Text.Name = "ContactAgent_Text";
            this.ContactAgent_Text.Size = new System.Drawing.Size(100, 20);
            this.ContactAgent_Text.TabIndex = 65;
            this.ContactAgent_Text.TextChanged += new System.EventHandler(this.ContactAgent_Text_TextChanged);
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(108, 22);
            this.Name_Text.MaxLength = 12;
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(100, 20);
            this.Name_Text.TabIndex = 64;
            this.Name_Text.TextChanged += new System.EventHandler(this.Name_Text_TextChanged);
            // 
            // E_Mail_Text
            // 
            this.E_Mail_Text.Location = new System.Drawing.Point(108, 164);
            this.E_Mail_Text.MaxLength = 50;
            this.E_Mail_Text.Name = "E_Mail_Text";
            this.E_Mail_Text.Size = new System.Drawing.Size(100, 20);
            this.E_Mail_Text.TabIndex = 63;
            // 
            // Address_Text
            // 
            this.Address_Text.Location = new System.Drawing.Point(108, 128);
            this.Address_Text.MaxLength = 50;
            this.Address_Text.Name = "Address_Text";
            this.Address_Text.Size = new System.Drawing.Size(100, 20);
            this.Address_Text.TabIndex = 62;
            // 
            // ContactAgentID_Label
            // 
            this.ContactAgentID_Label.AutoSize = true;
            this.ContactAgentID_Label.Location = new System.Drawing.Point(13, 198);
            this.ContactAgentID_Label.Name = "ContactAgentID_Label";
            this.ContactAgentID_Label.Size = new System.Drawing.Size(89, 13);
            this.ContactAgentID_Label.TabIndex = 61;
            this.ContactAgentID_Label.Text = "Contact Agent ID";
            // 
            // CompanyName_Label
            // 
            this.CompanyName_Label.AutoSize = true;
            this.CompanyName_Label.Location = new System.Drawing.Point(13, 22);
            this.CompanyName_Label.Name = "CompanyName_Label";
            this.CompanyName_Label.Size = new System.Drawing.Size(35, 13);
            this.CompanyName_Label.TabIndex = 60;
            this.CompanyName_Label.Text = "Name";
            // 
            // E_Mail_Label
            // 
            this.E_Mail_Label.AutoSize = true;
            this.E_Mail_Label.Location = new System.Drawing.Point(13, 167);
            this.E_Mail_Label.Name = "E_Mail_Label";
            this.E_Mail_Label.Size = new System.Drawing.Size(34, 13);
            this.E_Mail_Label.TabIndex = 59;
            this.E_Mail_Label.Text = "e-mail";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Location = new System.Drawing.Point(13, 131);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(45, 13);
            this.Address_Label.TabIndex = 58;
            this.Address_Label.Text = "Address";
            // 
            // OurAgent_CB
            // 
            this.OurAgent_CB.FormattingEnabled = true;
            this.OurAgent_CB.Location = new System.Drawing.Point(108, 229);
            this.OurAgent_CB.Name = "OurAgent_CB";
            this.OurAgent_CB.Size = new System.Drawing.Size(100, 21);
            this.OurAgent_CB.TabIndex = 72;
            this.OurAgent_CB.SelectedIndexChanged += new System.EventHandler(this.OurAgent_CB_SelectedIndexChanged);
            // 
            // OurAgentID_Label
            // 
            this.OurAgentID_Label.AutoSize = true;
            this.OurAgentID_Label.Location = new System.Drawing.Point(13, 232);
            this.OurAgentID_Label.Name = "OurAgentID_Label";
            this.OurAgentID_Label.Size = new System.Drawing.Size(69, 13);
            this.OurAgentID_Label.TabIndex = 71;
            this.OurAgentID_Label.Text = "Our Agent ID";
            // 
            // Activity_Text
            // 
            this.Activity_Text.Location = new System.Drawing.Point(108, 57);
            this.Activity_Text.MaxLength = 12;
            this.Activity_Text.Name = "Activity_Text";
            this.Activity_Text.Size = new System.Drawing.Size(100, 20);
            this.Activity_Text.TabIndex = 74;
            // 
            // Actitvity_Label
            // 
            this.Actitvity_Label.AutoSize = true;
            this.Actitvity_Label.Location = new System.Drawing.Point(13, 60);
            this.Actitvity_Label.Name = "Actitvity_Label";
            this.Actitvity_Label.Size = new System.Drawing.Size(41, 13);
            this.Actitvity_Label.TabIndex = 73;
            this.Actitvity_Label.Text = "Activity";
            // 
            // companyIDCB
            // 
            this.companyIDCB.FormattingEnabled = true;
            this.companyIDCB.Items.AddRange(new object[] {
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
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200"});
            this.companyIDCB.Location = new System.Drawing.Point(108, 91);
            this.companyIDCB.Name = "companyIDCB";
            this.companyIDCB.Size = new System.Drawing.Size(100, 21);
            this.companyIDCB.TabIndex = 76;
            this.companyIDCB.SelectedIndexChanged += new System.EventHandler(this.companyIDCB_SelectedIndexChanged);
            // 
            // Company_ID_Label
            // 
            this.Company_ID_Label.AutoSize = true;
            this.Company_ID_Label.Location = new System.Drawing.Point(13, 94);
            this.Company_ID_Label.Name = "Company_ID_Label";
            this.Company_ID_Label.Size = new System.Drawing.Size(18, 13);
            this.Company_ID_Label.TabIndex = 75;
            this.Company_ID_Label.Text = "ID";
            // 
            // Delete_Company
            // 
            this.Delete_Company.Location = new System.Drawing.Point(10, 281);
            this.Delete_Company.Name = "Delete_Company";
            this.Delete_Company.Size = new System.Drawing.Size(98, 23);
            this.Delete_Company.TabIndex = 79;
            this.Delete_Company.Text = "Delete Company";
            this.Delete_Company.UseVisualStyleBackColor = true;
            this.Delete_Company.Click += new System.EventHandler(this.Delete_Company_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(214, 281);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 78;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Save_Add_Edit_Button
            // 
            this.Save_Add_Edit_Button.Enabled = false;
            this.Save_Add_Edit_Button.Location = new System.Drawing.Point(124, 281);
            this.Save_Add_Edit_Button.Name = "Save_Add_Edit_Button";
            this.Save_Add_Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Add_Edit_Button.TabIndex = 77;
            this.Save_Add_Edit_Button.Text = "Save";
            this.Save_Add_Edit_Button.UseVisualStyleBackColor = true;
            this.Save_Add_Edit_Button.Click += new System.EventHandler(this.Save_Add_Edit_Button_Click);
            // 
            // Add_Edit_Sponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 332);
            this.Controls.Add(this.Delete_Company);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Save_Add_Edit_Button);
            this.Controls.Add(this.companyIDCB);
            this.Controls.Add(this.Company_ID_Label);
            this.Controls.Add(this.Activity_Text);
            this.Controls.Add(this.Actitvity_Label);
            this.Controls.Add(this.OurAgent_CB);
            this.Controls.Add(this.OurAgentID_Label);
            this.Controls.Add(this.ContactAgent_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.E_Mail_Text);
            this.Controls.Add(this.Address_Text);
            this.Controls.Add(this.ContactAgentID_Label);
            this.Controls.Add(this.CompanyName_Label);
            this.Controls.Add(this.E_Mail_Label);
            this.Controls.Add(this.Address_Label);
            this.Name = "Add_Edit_Sponsor";
            this.Text = "Add_Edit_Sponsor";
            this.Load += new System.EventHandler(this.Add_Edit_Sponsor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContactAgent_Text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox E_Mail_Text;
        private System.Windows.Forms.TextBox Address_Text;
        private System.Windows.Forms.Label ContactAgentID_Label;
        private System.Windows.Forms.Label CompanyName_Label;
        private System.Windows.Forms.Label E_Mail_Label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.ComboBox OurAgent_CB;
        private System.Windows.Forms.Label OurAgentID_Label;
        private System.Windows.Forms.TextBox Activity_Text;
        private System.Windows.Forms.Label Actitvity_Label;
        private System.Windows.Forms.ComboBox companyIDCB;
        private System.Windows.Forms.Label Company_ID_Label;
        private System.Windows.Forms.Button Delete_Company;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Save_Add_Edit_Button;
    }
}