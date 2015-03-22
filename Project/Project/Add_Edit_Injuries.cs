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
using System.Data.SqlTypes;

namespace Project
{
    public partial class Add_Edit_Injuries : Form
    {
        int IsAdd;
        User CurrentUser = new User();
        public Add_Edit_Injuries(int isAdd , User CurUsr)
        {
            InitializeComponent();
            this.CurrentUser = CurUsr;
            IsAdd = isAdd;
            if (isAdd == 1)
            {
                this.Text = "Add Injury";
                this.Delete_Injury_Button.Hide();
                this.Set_Constraints();
            }
            else if (isAdd == 2)
            {
                this.Text = "Edit Injury";
                this.InjuryIDCB.Enabled = false;
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Edit_Injuries_Load(object sender, EventArgs e)
        {
            string S = "SELECT Kit_Number FROM Player ; ";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while(reader.Read())
                    this.PlayerInjuredCB.Items.Add(reader.GetString(0));
            reader.Close();

            myCommand.CommandText = "SELECT Employee.ESSN FROM Employee JOIN Job ON Employee.Job_ID = Job.ID WHERE Job.Name = 'Doctor'; ";

            reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    this.DoctorCB.Items.Add(reader.GetString(0));
            reader.Close();

            myCommand.CommandText = "SELECT ID FROM Injury_Type;";

            reader = myCommand.ExecuteReader();

            while(reader.Read())
            {
                this.InjuryTypeCB.Items.Add(reader.GetInt32(0));
            }
            reader.Close();
        }
        private void Save_Add_Edit_Button_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@isAdd", this.IsAdd);
            Parameters.Add("@ID", this.InjuryIDCB.Text);
            Parameters.Add("@Player_Kit_No", this.PlayerInjuredCB.Text);
            Parameters.Add("@Injury_Type_ID", this.InjuryTypeCB.Text);
            Parameters.Add("@Doctor_ID",this.DoctorCB.Text);
            Parameters.Add("@IsHealed", this.Healed_CB.Text);
            Parameters.Add("@Date", this.Injury_Date_Picker.Text);
       
            DBManager DBm = new DBManager();
            int Result = DBm.ExecuteNonQuery(StoredProcedures.Add_Update_Injuries, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved.");

                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string S;
                if (IsAdd == 1)
                    S = "User Added new Injury With ID: " + this.InjuryIDCB.Text + ".";
                else if (IsAdd == 2)
                    S = "User Edited Injury With ID: " + this.InjuryIDCB.Text + ".";
                else
                    S = "User Deleted Record From Injuries";
                MLK.InsertData(CurrentUser.UserName, S);

            }
            else
            {
                MessageBox.Show("Error");
            }
            this.Close();

        }

        private void Delete_Injury_Button_Click(object sender, EventArgs e)
        {
            this.IsAdd = 3;
            this.Save_Add_Edit_Button_Click(sender, e);
        }

        public void SetDataBeforeEdit(DataGridView datagrid , int Ind)
        {
            this.InjuryIDCB.Text = datagrid.Rows[Ind].Cells[0].Value.ToString();
            this.Injury_Date_Picker.Text = datagrid.Rows[Ind].Cells[1].Value.ToString();
            this.PlayerInjuredCB.Text = datagrid.Rows[Ind].Cells[3].Value.ToString();
            this.InjuryTypeCB.Text = datagrid.Rows[Ind].Cells[5].Value.ToString();
            this.DoctorCB.Text = datagrid.Rows[Ind].Cells[4].Value.ToString();
            this.Healed_CB.Text = datagrid.Rows[Ind].Cells[2].Value.ToString();
        }


        private void Set_Constraints()
        {
            string S = "SELECT ID FROM Injuries;";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    S = reader.GetInt32(0).ToString();
                    for (int i = 0; i < this.InjuryIDCB.Items.Count; i++)
                    {
                        if (this.InjuryIDCB.Items.Contains(S))
                        {
                            this.InjuryIDCB.Items.Remove(S);
                            i--;
                            continue;
                        }
                    }
                }
            reader.Close();
        }

        private void Check()
        {
            if (this.InjuryIDCB.Text != "" && this.Injury_Date_Picker.Text != "" && this.PlayerInjuredCB.Text != "" && this.DoctorCB.Text != "" && this.InjuryTypeCB.Text != "")
                this.Save_Add_Edit_Button.Enabled = true;
            else this.Save_Add_Edit_Button.Enabled = false;
        }

        private void Injury_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void PlayerInjuredCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void DoctorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void InjuryTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void InjuryIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }
    }
}
