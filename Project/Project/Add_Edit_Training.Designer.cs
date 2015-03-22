namespace Project
{
    partial class Add_Edit_Training
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
            this.Save_Add_Edit_Button = new System.Windows.Forms.Button();
            this.Delete_Training_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Period_Text = new System.Windows.Forms.TextBox();
            this.PlayGround_Text = new System.Windows.Forms.TextBox();
            this.Training_Type_CB = new System.Windows.Forms.ComboBox();
            this.Country_Label = new System.Windows.Forms.Label();
            this.PlayGround_Label = new System.Windows.Forms.Label();
            this.Opponent_Label = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Country_CB = new System.Windows.Forms.ComboBox();
            this.Star_Date = new System.Windows.Forms.Label();
            this.Start_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.TrainingIDCB = new System.Windows.Forms.ComboBox();
            this.Training_ID_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_Add_Edit_Button
            // 
            this.Save_Add_Edit_Button.Enabled = false;
            this.Save_Add_Edit_Button.Location = new System.Drawing.Point(130, 255);
            this.Save_Add_Edit_Button.Name = "Save_Add_Edit_Button";
            this.Save_Add_Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Add_Edit_Button.TabIndex = 46;
            this.Save_Add_Edit_Button.Text = "Save";
            this.Save_Add_Edit_Button.UseVisualStyleBackColor = true;
            this.Save_Add_Edit_Button.Click += new System.EventHandler(this.Save_Add_Edit_Button_Click);
            // 
            // Delete_Training_Button
            // 
            this.Delete_Training_Button.Location = new System.Drawing.Point(23, 255);
            this.Delete_Training_Button.Name = "Delete_Training_Button";
            this.Delete_Training_Button.Size = new System.Drawing.Size(90, 23);
            this.Delete_Training_Button.TabIndex = 45;
            this.Delete_Training_Button.Text = "Delete Training";
            this.Delete_Training_Button.UseVisualStyleBackColor = true;
            this.Delete_Training_Button.Click += new System.EventHandler(this.Delete_Training_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(222, 255);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 44;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Period_Text
            // 
            this.Period_Text.Location = new System.Drawing.Point(120, 128);
            this.Period_Text.Name = "Period_Text";
            this.Period_Text.Size = new System.Drawing.Size(121, 20);
            this.Period_Text.TabIndex = 43;
            this.Period_Text.TextChanged += new System.EventHandler(this.Period_Text_TextChanged);
            // 
            // PlayGround_Text
            // 
            this.PlayGround_Text.Location = new System.Drawing.Point(120, 164);
            this.PlayGround_Text.Name = "PlayGround_Text";
            this.PlayGround_Text.Size = new System.Drawing.Size(121, 20);
            this.PlayGround_Text.TabIndex = 42;
            // 
            // Training_Type_CB
            // 
            this.Training_Type_CB.FormattingEnabled = true;
            this.Training_Type_CB.Location = new System.Drawing.Point(120, 89);
            this.Training_Type_CB.Name = "Training_Type_CB";
            this.Training_Type_CB.Size = new System.Drawing.Size(121, 21);
            this.Training_Type_CB.TabIndex = 37;
            this.Training_Type_CB.SelectedIndexChanged += new System.EventHandler(this.Training_Type_CB_SelectedIndexChanged);
            // 
            // Country_Label
            // 
            this.Country_Label.AutoSize = true;
            this.Country_Label.Location = new System.Drawing.Point(18, 206);
            this.Country_Label.Name = "Country_Label";
            this.Country_Label.Size = new System.Drawing.Size(43, 13);
            this.Country_Label.TabIndex = 32;
            this.Country_Label.Text = "Country";
            // 
            // PlayGround_Label
            // 
            this.PlayGround_Label.AutoSize = true;
            this.PlayGround_Label.Location = new System.Drawing.Point(18, 167);
            this.PlayGround_Label.Name = "PlayGround_Label";
            this.PlayGround_Label.Size = new System.Drawing.Size(65, 13);
            this.PlayGround_Label.TabIndex = 31;
            this.PlayGround_Label.Text = "Play Ground";
            // 
            // Opponent_Label
            // 
            this.Opponent_Label.AutoSize = true;
            this.Opponent_Label.Location = new System.Drawing.Point(18, 131);
            this.Opponent_Label.Name = "Opponent_Label";
            this.Opponent_Label.Size = new System.Drawing.Size(37, 13);
            this.Opponent_Label.TabIndex = 30;
            this.Opponent_Label.Text = "Period";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(18, 92);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(72, 13);
            this.Type.TabIndex = 29;
            this.Type.Text = "Training Type";
            // 
            // Country_CB
            // 
            this.Country_CB.FormattingEnabled = true;
            this.Country_CB.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.Country_CB.Location = new System.Drawing.Point(120, 203);
            this.Country_CB.Name = "Country_CB";
            this.Country_CB.Size = new System.Drawing.Size(121, 21);
            this.Country_CB.TabIndex = 47;
            this.Country_CB.SelectedIndexChanged += new System.EventHandler(this.Country_CB_SelectedIndexChanged);
            // 
            // Star_Date
            // 
            this.Star_Date.AutoSize = true;
            this.Star_Date.Location = new System.Drawing.Point(18, 53);
            this.Star_Date.Name = "Star_Date";
            this.Star_Date.Size = new System.Drawing.Size(55, 13);
            this.Star_Date.TabIndex = 68;
            this.Star_Date.Text = "Start Date";
            // 
            // Start_Date_Picker
            // 
            this.Start_Date_Picker.CustomFormat = "MM-dd-yyyy HH:mm:ss";
            this.Start_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start_Date_Picker.Location = new System.Drawing.Point(120, 53);
            this.Start_Date_Picker.Name = "Start_Date_Picker";
            this.Start_Date_Picker.Size = new System.Drawing.Size(121, 20);
            this.Start_Date_Picker.TabIndex = 67;
            this.Start_Date_Picker.ValueChanged += new System.EventHandler(this.Start_Date_Picker_ValueChanged);
            // 
            // TrainingIDCB
            // 
            this.TrainingIDCB.FormattingEnabled = true;
            this.TrainingIDCB.Items.AddRange(new object[] {
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
            this.TrainingIDCB.Location = new System.Drawing.Point(120, 21);
            this.TrainingIDCB.Name = "TrainingIDCB";
            this.TrainingIDCB.Size = new System.Drawing.Size(121, 21);
            this.TrainingIDCB.TabIndex = 78;
            this.TrainingIDCB.SelectedIndexChanged += new System.EventHandler(this.TrainingIDCB_SelectedIndexChanged);
            // 
            // Training_ID_Label
            // 
            this.Training_ID_Label.AutoSize = true;
            this.Training_ID_Label.Location = new System.Drawing.Point(20, 29);
            this.Training_ID_Label.Name = "Training_ID_Label";
            this.Training_ID_Label.Size = new System.Drawing.Size(18, 13);
            this.Training_ID_Label.TabIndex = 77;
            this.Training_ID_Label.Text = "ID";
            // 
            // Add_Edit_Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 308);
            this.Controls.Add(this.TrainingIDCB);
            this.Controls.Add(this.Training_ID_Label);
            this.Controls.Add(this.Star_Date);
            this.Controls.Add(this.Start_Date_Picker);
            this.Controls.Add(this.Country_CB);
            this.Controls.Add(this.Save_Add_Edit_Button);
            this.Controls.Add(this.Delete_Training_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Period_Text);
            this.Controls.Add(this.PlayGround_Text);
            this.Controls.Add(this.Training_Type_CB);
            this.Controls.Add(this.Country_Label);
            this.Controls.Add(this.PlayGround_Label);
            this.Controls.Add(this.Opponent_Label);
            this.Controls.Add(this.Type);
            this.Name = "Add_Edit_Training";
            this.Text = "Add_Edit_Training";
            this.Load += new System.EventHandler(this.Add_Edit_Training_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Add_Edit_Button;
        private System.Windows.Forms.Button Delete_Training_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.TextBox Period_Text;
        private System.Windows.Forms.TextBox PlayGround_Text;
        private System.Windows.Forms.ComboBox Training_Type_CB;
        private System.Windows.Forms.Label Country_Label;
        private System.Windows.Forms.Label PlayGround_Label;
        private System.Windows.Forms.Label Opponent_Label;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.ComboBox Country_CB;
        private System.Windows.Forms.Label Star_Date;
        private System.Windows.Forms.DateTimePicker Start_Date_Picker;
        private System.Windows.Forms.ComboBox TrainingIDCB;
        private System.Windows.Forms.Label Training_ID_Label;
    }
}