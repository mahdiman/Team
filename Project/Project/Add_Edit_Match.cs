using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    using System.Data.SqlClient;
    public partial class Add_Edit_Match : Form
    {
        int IsAdd;
        User CurrentUser = new User();
        public Add_Edit_Match(int isAdd , User CurUsr)
        {
            InitializeComponent();
            this.CurrentUser = CurUsr;
            IsAdd = isAdd;
            if (isAdd == 1)
            {
                this.Text = "Add Match";
                this.Delete_Match_Button.Hide();
            }
            else if (isAdd == 2)
                this.Text = "Edit Match";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Edit_Match_Load(object sender, EventArgs e)
        {
            string S = "SELECT ID FROM Competition_Par_In ; ";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    this.Comp_ID_CB.Items.Add(reader.GetInt32(0).ToString());
            reader.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Add_Edit_Button_Click(object sender, EventArgs e)
        {
            string S;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@isAdd", this.IsAdd);
            Parameters.Add("@Date", this.Start_Date_Picker.Text);
            if (this.Comp_ID_CB.Text != "")
            {
                Parameters.Add("@Comp_ID", Int32.Parse(this.Comp_ID_CB.Text));
                S = StoredProcedures.Add_Update_Match;
            }
            else
                S = StoredProcedures.Add_Update_Match1;
            Parameters.Add("@Opponent", this.Opponent_Text.Text);
            Parameters.Add("@Stadium", this.Staduim_Text.Text);
            Parameters.Add("@Match_Result", Our_Goals_CB.Text +"-"+ Opponent_Goals_CB.Text);
            DBManager DBm = new DBManager();


            int Result = DBm.ExecuteNonQuery(S, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved");

                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string B;
                if (IsAdd == 1)
                    B = "User Added new Match With ON: " + this.Start_Date_Picker.Text + ".";
                else if (IsAdd == 2)
                    B = "User Edited Match ON: " + this.Start_Date_Picker.Text + ".";
                else
                    B = "User Deleted Record From Matches";
                MLK.InsertData(CurrentUser.UserName, B);

            }
            else
                MessageBox.Show("Error");
            this.Close();
        }



        public void SetDataBeforEdit(DataGridView datagrid, int Ind)
        {
            this.Start_Date_Picker.Text = datagrid.Rows[Ind].Cells[0].Value.ToString();
            this.Opponent_Text.Text = datagrid.Rows[Ind].Cells[1].Value.ToString();
            this.Comp_ID_CB.Text = datagrid.Rows[Ind].Cells[2].Value.ToString();
            this.Staduim_Text.Text = datagrid.Rows[Ind].Cells[3].Value.ToString();
            string S1 = datagrid.Rows[Ind].Cells[4].Value.ToString();
            
            for(int i = 0 ; i < S1.Length; i++) 
            {
                if (S1[i] == '-')
                {
                    this.Opponent_Goals_CB.Text = S1.Substring(i + 1, S1.Length - i - 1);
                    this.Our_Goals_CB.Text = S1.Substring(0, i );
                    break;
                }
            }


        }

        private void Delete_Match_Button_Click(object sender, EventArgs e)
        {
            this.IsAdd = 3;
            this.Save_Add_Edit_Button_Click(sender, e);
        }


        private void Check()
        {
            if (this.Start_Date_Picker.Text != "" && this.Opponent_Text.Text != "")
                this.Save_Add_Edit_Button.Enabled = true;
            else
                this.Save_Add_Edit_Button.Enabled = false;
        }

        private void Start_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Opponent_Text_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

    }
}
