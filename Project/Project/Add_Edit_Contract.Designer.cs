namespace Project
{
    partial class Add_Edit_Contract
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
            this.SecondPartyIDCB = new System.Windows.Forms.ComboBox();
            this.c = new System.Windows.Forms.Label();
            this.SecondPartyTypeCB = new System.Windows.Forms.ComboBox();
            this.Second_Party_Type_Label = new System.Windows.Forms.Label();
            this.ContractIDCB = new System.Windows.Forms.ComboBox();
            this.ContractID = new System.Windows.Forms.Label();
            this.Save_Add_Edit_Button = new System.Windows.Forms.Button();
            this.Delete_Contract_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Start_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.End_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.Start_Date = new System.Windows.Forms.Label();
            this.End_Date = new System.Windows.Forms.Label();
            this.Content_Text = new System.Windows.Forms.TextBox();
            this.Content_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecondPartyIDCB
            // 
            this.SecondPartyIDCB.FormattingEnabled = true;
            this.SecondPartyIDCB.Location = new System.Drawing.Point(116, 221);
            this.SecondPartyIDCB.Name = "SecondPartyIDCB";
            this.SecondPartyIDCB.Size = new System.Drawing.Size(79, 21);
            this.SecondPartyIDCB.TabIndex = 65;
            this.SecondPartyIDCB.SelectedIndexChanged += new System.EventHandler(this.SecondPartyIDCB_SelectedIndexChanged);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(31, 224);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(66, 13);
            this.c.TabIndex = 64;
            this.c.Text = "2nd Party ID";
            // 
            // SecondPartyTypeCB
            // 
            this.SecondPartyTypeCB.FormattingEnabled = true;
            this.SecondPartyTypeCB.Items.AddRange(new object[] {
            "Player",
            "Employee",
            "Sponsor"});
            this.SecondPartyTypeCB.Location = new System.Drawing.Point(116, 183);
            this.SecondPartyTypeCB.Name = "SecondPartyTypeCB";
            this.SecondPartyTypeCB.Size = new System.Drawing.Size(79, 21);
            this.SecondPartyTypeCB.TabIndex = 63;
            this.SecondPartyTypeCB.SelectedIndexChanged += new System.EventHandler(this.SecondPartyTypeCB_SelectedIndexChanged);
            // 
            // Second_Party_Type_Label
            // 
            this.Second_Party_Type_Label.AutoSize = true;
            this.Second_Party_Type_Label.Location = new System.Drawing.Point(31, 186);
            this.Second_Party_Type_Label.Name = "Second_Party_Type_Label";
            this.Second_Party_Type_Label.Size = new System.Drawing.Size(79, 13);
            this.Second_Party_Type_Label.TabIndex = 62;
            this.Second_Party_Type_Label.Text = "2nd Party Type";
            // 
            // ContractIDCB
            // 
            this.ContractIDCB.FormattingEnabled = true;
            this.ContractIDCB.Items.AddRange(new object[] {
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
            this.ContractIDCB.Location = new System.Drawing.Point(115, 136);
            this.ContractIDCB.Name = "ContractIDCB";
            this.ContractIDCB.Size = new System.Drawing.Size(80, 21);
            this.ContractIDCB.TabIndex = 67;
            this.ContractIDCB.SelectedIndexChanged += new System.EventHandler(this.ContractIDCB_SelectedIndexChanged);
            // 
            // ContractID
            // 
            this.ContractID.AutoSize = true;
            this.ContractID.Location = new System.Drawing.Point(31, 139);
            this.ContractID.Name = "ContractID";
            this.ContractID.Size = new System.Drawing.Size(61, 13);
            this.ContractID.TabIndex = 66;
            this.ContractID.Text = "Contract ID";
            this.ContractID.Click += new System.EventHandler(this.ContractID_Click);
            // 
            // Save_Add_Edit_Button
            // 
            this.Save_Add_Edit_Button.Enabled = false;
            this.Save_Add_Edit_Button.Location = new System.Drawing.Point(395, 309);
            this.Save_Add_Edit_Button.Name = "Save_Add_Edit_Button";
            this.Save_Add_Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Add_Edit_Button.TabIndex = 71;
            this.Save_Add_Edit_Button.Text = "Save";
            this.Save_Add_Edit_Button.UseVisualStyleBackColor = true;
            this.Save_Add_Edit_Button.Click += new System.EventHandler(this.Save_Add_Edit_Button_Click);
            // 
            // Delete_Contract_Button
            // 
            this.Delete_Contract_Button.Location = new System.Drawing.Point(261, 309);
            this.Delete_Contract_Button.Name = "Delete_Contract_Button";
            this.Delete_Contract_Button.Size = new System.Drawing.Size(117, 23);
            this.Delete_Contract_Button.TabIndex = 70;
            this.Delete_Contract_Button.Text = "Delete Contract";
            this.Delete_Contract_Button.UseVisualStyleBackColor = true;
            this.Delete_Contract_Button.Click += new System.EventHandler(this.Delete_Contract_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(487, 309);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 69;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Start_Date_Picker
            // 
            this.Start_Date_Picker.CustomFormat = "MM-dd-yyyy";
            this.Start_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start_Date_Picker.Location = new System.Drawing.Point(116, 36);
            this.Start_Date_Picker.Name = "Start_Date_Picker";
            this.Start_Date_Picker.Size = new System.Drawing.Size(119, 20);
            this.Start_Date_Picker.TabIndex = 72;
            this.Start_Date_Picker.ValueChanged += new System.EventHandler(this.Start_Date_Picker_ValueChanged);
            // 
            // End_Date_Picker
            // 
            this.End_Date_Picker.CustomFormat = "MM-dd-yyyy";
            this.End_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.End_Date_Picker.Location = new System.Drawing.Point(116, 84);
            this.End_Date_Picker.Name = "End_Date_Picker";
            this.End_Date_Picker.Size = new System.Drawing.Size(119, 20);
            this.End_Date_Picker.TabIndex = 73;
            this.End_Date_Picker.ValueChanged += new System.EventHandler(this.End_Date_Picker_ValueChanged);
            // 
            // Start_Date
            // 
            this.Start_Date.AutoSize = true;
            this.Start_Date.Location = new System.Drawing.Point(31, 42);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(55, 13);
            this.Start_Date.TabIndex = 74;
            this.Start_Date.Text = "Start Date";
            // 
            // End_Date
            // 
            this.End_Date.AutoSize = true;
            this.End_Date.Location = new System.Drawing.Point(31, 90);
            this.End_Date.Name = "End_Date";
            this.End_Date.Size = new System.Drawing.Size(52, 13);
            this.End_Date.TabIndex = 75;
            this.End_Date.Text = "End Date";
            // 
            // Content_Text
            // 
            this.Content_Text.Location = new System.Drawing.Point(353, 39);
            this.Content_Text.Multiline = true;
            this.Content_Text.Name = "Content_Text";
            this.Content_Text.Size = new System.Drawing.Size(209, 235);
            this.Content_Text.TabIndex = 76;
            this.Content_Text.TextChanged += new System.EventHandler(this.Content_Text_TextChanged);
            // 
            // Content_Label
            // 
            this.Content_Label.AutoSize = true;
            this.Content_Label.Location = new System.Drawing.Point(288, 42);
            this.Content_Label.Name = "Content_Label";
            this.Content_Label.Size = new System.Drawing.Size(44, 13);
            this.Content_Label.TabIndex = 77;
            this.Content_Label.Text = "Content";
            // 
            // Add_Edit_Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 355);
            this.Controls.Add(this.Content_Label);
            this.Controls.Add(this.Content_Text);
            this.Controls.Add(this.End_Date);
            this.Controls.Add(this.Start_Date);
            this.Controls.Add(this.End_Date_Picker);
            this.Controls.Add(this.Start_Date_Picker);
            this.Controls.Add(this.Save_Add_Edit_Button);
            this.Controls.Add(this.Delete_Contract_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.ContractIDCB);
            this.Controls.Add(this.ContractID);
            this.Controls.Add(this.SecondPartyIDCB);
            this.Controls.Add(this.c);
            this.Controls.Add(this.SecondPartyTypeCB);
            this.Controls.Add(this.Second_Party_Type_Label);
            this.Name = "Add_Edit_Contract";
            this.Text = "Add_Edit_Contract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SecondPartyIDCB;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.ComboBox SecondPartyTypeCB;
        private System.Windows.Forms.Label Second_Party_Type_Label;
        private System.Windows.Forms.ComboBox ContractIDCB;
        private System.Windows.Forms.Label ContractID;
        private System.Windows.Forms.Button Save_Add_Edit_Button;
        private System.Windows.Forms.Button Delete_Contract_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.DateTimePicker Start_Date_Picker;
        private System.Windows.Forms.DateTimePicker End_Date_Picker;
        private System.Windows.Forms.Label Start_Date;
        private System.Windows.Forms.Label End_Date;
        private System.Windows.Forms.TextBox Content_Text;
        private System.Windows.Forms.Label Content_Label;
    }
}