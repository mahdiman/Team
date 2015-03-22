namespace Project
{
    partial class Add_Edit_Injuries
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
            this.DoctorCB = new System.Windows.Forms.ComboBox();
            this.Doctor_Responsible_Label = new System.Windows.Forms.Label();
            this.PlayerInjuredCB = new System.Windows.Forms.ComboBox();
            this.Player_Injured_Label = new System.Windows.Forms.Label();
            this.InjuryTypeCB = new System.Windows.Forms.ComboBox();
            this.Injury_Type = new System.Windows.Forms.Label();
            this.InjuryIDCB = new System.Windows.Forms.ComboBox();
            this.Injury_ID_Label = new System.Windows.Forms.Label();
            this.Save_Add_Edit_Button = new System.Windows.Forms.Button();
            this.Delete_Injury_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Healed_CB = new System.Windows.Forms.ComboBox();
            this.Healed_Label = new System.Windows.Forms.Label();
            this.Injury_Date = new System.Windows.Forms.Label();
            this.Injury_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // DoctorCB
            // 
            this.DoctorCB.FormattingEnabled = true;
            this.DoctorCB.Location = new System.Drawing.Point(90, 102);
            this.DoctorCB.Name = "DoctorCB";
            this.DoctorCB.Size = new System.Drawing.Size(121, 21);
            this.DoctorCB.TabIndex = 55;
            this.DoctorCB.SelectedIndexChanged += new System.EventHandler(this.DoctorCB_SelectedIndexChanged);
            // 
            // Doctor_Responsible_Label
            // 
            this.Doctor_Responsible_Label.AutoSize = true;
            this.Doctor_Responsible_Label.Location = new System.Drawing.Point(13, 110);
            this.Doctor_Responsible_Label.Name = "Doctor_Responsible_Label";
            this.Doctor_Responsible_Label.Size = new System.Drawing.Size(39, 13);
            this.Doctor_Responsible_Label.TabIndex = 54;
            this.Doctor_Responsible_Label.Text = "Doctor";
            // 
            // PlayerInjuredCB
            // 
            this.PlayerInjuredCB.FormattingEnabled = true;
            this.PlayerInjuredCB.Location = new System.Drawing.Point(90, 63);
            this.PlayerInjuredCB.Name = "PlayerInjuredCB";
            this.PlayerInjuredCB.Size = new System.Drawing.Size(121, 21);
            this.PlayerInjuredCB.TabIndex = 57;
            this.PlayerInjuredCB.SelectedIndexChanged += new System.EventHandler(this.PlayerInjuredCB_SelectedIndexChanged);
            // 
            // Player_Injured_Label
            // 
            this.Player_Injured_Label.AutoSize = true;
            this.Player_Injured_Label.Location = new System.Drawing.Point(13, 66);
            this.Player_Injured_Label.Name = "Player_Injured_Label";
            this.Player_Injured_Label.Size = new System.Drawing.Size(71, 13);
            this.Player_Injured_Label.TabIndex = 56;
            this.Player_Injured_Label.Text = "Player Injured";
            // 
            // InjuryTypeCB
            // 
            this.InjuryTypeCB.FormattingEnabled = true;
            this.InjuryTypeCB.Location = new System.Drawing.Point(90, 150);
            this.InjuryTypeCB.Name = "InjuryTypeCB";
            this.InjuryTypeCB.Size = new System.Drawing.Size(121, 21);
            this.InjuryTypeCB.TabIndex = 59;
            this.InjuryTypeCB.SelectedIndexChanged += new System.EventHandler(this.InjuryTypeCB_SelectedIndexChanged);
            // 
            // Injury_Type
            // 
            this.Injury_Type.AutoSize = true;
            this.Injury_Type.Location = new System.Drawing.Point(13, 153);
            this.Injury_Type.Name = "Injury_Type";
            this.Injury_Type.Size = new System.Drawing.Size(59, 13);
            this.Injury_Type.TabIndex = 58;
            this.Injury_Type.Text = "Injury Type";
            // 
            // InjuryIDCB
            // 
            this.InjuryIDCB.FormattingEnabled = true;
            this.InjuryIDCB.Items.AddRange(new object[] {
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
            this.InjuryIDCB.Location = new System.Drawing.Point(90, 188);
            this.InjuryIDCB.Name = "InjuryIDCB";
            this.InjuryIDCB.Size = new System.Drawing.Size(121, 21);
            this.InjuryIDCB.TabIndex = 61;
            this.InjuryIDCB.SelectedIndexChanged += new System.EventHandler(this.InjuryIDCB_SelectedIndexChanged);
            // 
            // Injury_ID_Label
            // 
            this.Injury_ID_Label.AutoSize = true;
            this.Injury_ID_Label.Location = new System.Drawing.Point(13, 191);
            this.Injury_ID_Label.Name = "Injury_ID_Label";
            this.Injury_ID_Label.Size = new System.Drawing.Size(46, 13);
            this.Injury_ID_Label.TabIndex = 60;
            this.Injury_ID_Label.Text = "Injury ID";
            // 
            // Save_Add_Edit_Button
            // 
            this.Save_Add_Edit_Button.Enabled = false;
            this.Save_Add_Edit_Button.Location = new System.Drawing.Point(158, 287);
            this.Save_Add_Edit_Button.Name = "Save_Add_Edit_Button";
            this.Save_Add_Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Add_Edit_Button.TabIndex = 64;
            this.Save_Add_Edit_Button.Text = "Save";
            this.Save_Add_Edit_Button.UseVisualStyleBackColor = true;
            this.Save_Add_Edit_Button.Click += new System.EventHandler(this.Save_Add_Edit_Button_Click);
            // 
            // Delete_Injury_Button
            // 
            this.Delete_Injury_Button.Location = new System.Drawing.Point(24, 287);
            this.Delete_Injury_Button.Name = "Delete_Injury_Button";
            this.Delete_Injury_Button.Size = new System.Drawing.Size(117, 23);
            this.Delete_Injury_Button.TabIndex = 63;
            this.Delete_Injury_Button.Text = "Delete Injury";
            this.Delete_Injury_Button.UseVisualStyleBackColor = true;
            this.Delete_Injury_Button.Click += new System.EventHandler(this.Delete_Injury_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(250, 287);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 62;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Healed_CB
            // 
            this.Healed_CB.FormattingEnabled = true;
            this.Healed_CB.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Healed_CB.Location = new System.Drawing.Point(90, 234);
            this.Healed_CB.Name = "Healed_CB";
            this.Healed_CB.Size = new System.Drawing.Size(121, 21);
            this.Healed_CB.TabIndex = 66;
            // 
            // Healed_Label
            // 
            this.Healed_Label.AutoSize = true;
            this.Healed_Label.Location = new System.Drawing.Point(13, 237);
            this.Healed_Label.Name = "Healed_Label";
            this.Healed_Label.Size = new System.Drawing.Size(41, 13);
            this.Healed_Label.TabIndex = 65;
            this.Healed_Label.Text = "Healed";
            // 
            // Injury_Date
            // 
            this.Injury_Date.AutoSize = true;
            this.Injury_Date.Location = new System.Drawing.Point(13, 29);
            this.Injury_Date.Name = "Injury_Date";
            this.Injury_Date.Size = new System.Drawing.Size(58, 13);
            this.Injury_Date.TabIndex = 68;
            this.Injury_Date.Text = "Injury Date";
            // 
            // Injury_Date_Picker
            // 
            this.Injury_Date_Picker.CustomFormat = "MM-dd-yyyy";
            this.Injury_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Injury_Date_Picker.Location = new System.Drawing.Point(90, 23);
            this.Injury_Date_Picker.Name = "Injury_Date_Picker";
            this.Injury_Date_Picker.Size = new System.Drawing.Size(121, 20);
            this.Injury_Date_Picker.TabIndex = 67;
            this.Injury_Date_Picker.ValueChanged += new System.EventHandler(this.Injury_Date_Picker_ValueChanged);
            // 
            // Add_Edit_Injuries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 334);
            this.Controls.Add(this.Injury_Date);
            this.Controls.Add(this.Injury_Date_Picker);
            this.Controls.Add(this.Healed_CB);
            this.Controls.Add(this.Healed_Label);
            this.Controls.Add(this.Save_Add_Edit_Button);
            this.Controls.Add(this.Delete_Injury_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.InjuryIDCB);
            this.Controls.Add(this.Injury_ID_Label);
            this.Controls.Add(this.InjuryTypeCB);
            this.Controls.Add(this.Injury_Type);
            this.Controls.Add(this.PlayerInjuredCB);
            this.Controls.Add(this.Player_Injured_Label);
            this.Controls.Add(this.DoctorCB);
            this.Controls.Add(this.Doctor_Responsible_Label);
            this.Name = "Add_Edit_Injuries";
            this.Text = "Add_Edit_Injuries";
            this.Load += new System.EventHandler(this.Add_Edit_Injuries_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DoctorCB;
        private System.Windows.Forms.Label Doctor_Responsible_Label;
        private System.Windows.Forms.ComboBox PlayerInjuredCB;
        private System.Windows.Forms.Label Player_Injured_Label;
        private System.Windows.Forms.ComboBox InjuryTypeCB;
        private System.Windows.Forms.Label Injury_Type;
        private System.Windows.Forms.ComboBox InjuryIDCB;
        private System.Windows.Forms.Label Injury_ID_Label;
        private System.Windows.Forms.Button Save_Add_Edit_Button;
        private System.Windows.Forms.Button Delete_Injury_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.ComboBox Healed_CB;
        private System.Windows.Forms.Label Healed_Label;
        private System.Windows.Forms.Label Injury_Date;
        private System.Windows.Forms.DateTimePicker Injury_Date_Picker;
    }
}