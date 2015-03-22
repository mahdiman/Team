using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Add_Edit_Competition : Form
    {
        int IsAdd;
        User CurrentUser = new User();
        public Add_Edit_Competition(int isAdd , User CurUser)
        {
            this.CurrentUser = CurUser;
            InitializeComponent();
            IsAdd = isAdd;
            if (isAdd == 1)
            {
                this.Text = "Add New Competition";
                this.Delete_Competition_Button.Hide();
            }
            else if (isAdd == 2)
            {
                this.Text = "Edit Competition";
                this.ID_CB.Enabled = false;
            }

            this.Set_Constraints();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Add_Edit_Button_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@isAdd", this.IsAdd);
            Parameters.Add("@ID", Int32.Parse(this.ID_CB.Text));
            Parameters.Add("@Start_Date", this.Start_Date_Picker.Text);
            Parameters.Add("@End_Date", this.End_Date_Picker.Text);
            Parameters.Add("@Teams_Number", Int32.Parse(this.TeamNoCB.Text));
            Parameters.Add("@Country", this.Country_CB.Text);
            Parameters.Add("@Winner" , this.Winner_Text.Text);
            Parameters.Add("@Type", Int32.Parse(this.CompNameCB.Text));

            DBManager DBm = new DBManager();


            int Result = DBm.ExecuteNonQuery(StoredProcedures.Add_Update_Comp_Par_In, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved");

                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string S;
                if (IsAdd == 1)
                    S = "User Added new Championship With ID: " + this.ID_CB.Text + ".";
                else if (IsAdd == 2)
                    S = "User Edited Championship With ID: " + this.ID_CB.Text + ".";
                else
                    S = "User Deleted Record From Championship";
                MLK.InsertData(CurrentUser.UserName, S);

            }
            else
                MessageBox.Show("Error");
            this.Close();
        }

        private void Add_Edit_Competition_Load(object sender, EventArgs e)
        {
            string S = "SELECT ID FROM Competition_Type ; ";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    this.CompNameCB.Items.Add(reader.GetInt32(0).ToString());
            reader.Close();
        }



        public void SetDataBeforEdit(DataGridView datagrid, int Ind)
        {
            this.ID_CB.Text = datagrid.Rows[Ind].Cells[0].Value.ToString();
            this.Start_Date_Picker.Text = datagrid.Rows[Ind].Cells[1].Value.ToString();
            this.End_Date_Picker.Text = datagrid.Rows[Ind].Cells[2].Value.ToString();
            this.TeamNoCB.Text = datagrid.Rows[Ind].Cells[3].Value.ToString();
            this.Country_CB.Text = datagrid.Rows[Ind].Cells[4].Value.ToString();
            this.Winner_Text.Text = datagrid.Rows[Ind].Cells[5].Value.ToString();
            this.CompNameCB.Text = datagrid.Rows[Ind].Cells[6].Value.ToString();
            
        }

        private void Delete_Competition_Button_Click(object sender, EventArgs e)
        {
            this.IsAdd = 3;
            this.Save_Add_Edit_Button_Click(sender, e);
        }

        private void Set_Constraints()
        {
            string S = "SELECT ID FROM Competition_Par_In;";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    S = reader.GetInt32(0).ToString();
                    for (int i = 0; i < this.ID_CB.Items.Count; i++)
                    {
                        if (this.ID_CB.Items.Contains(S))
                        {
                            this.ID_CB.Items.Remove(S);
                            i--;
                            continue;
                        }
                    }
                }
            reader.Close();
        }

        private void Check()
        {
            if (this.End_Date_Picker.Text != "" && this.Start_Date_Picker.Text != "" && this.ID_CB.Text != "" && this.Country_CB.Text != "" && this.TeamNoCB.Text != "")
                this.Save_Add_Edit_Button.Enabled = true;
            else
                this.Save_Add_Edit_Button.Enabled = false;
        }

        private void Start_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void End_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Country_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void ID_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void CompNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void TeamNoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

    }
}
