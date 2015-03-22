using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;

namespace Project
{
    public partial class Add_Edit_Contract : Form
    {
        int IsAdd;
        User CurrentUser = new User();
        public Add_Edit_Contract(int isAdd , User CurUsr)
        {
            InitializeComponent();
            IsAdd = isAdd;
            this.CurrentUser = CurUsr;
            if(isAdd==1)
            {
                this.Text = "Add New Contract";
                this.Delete_Contract_Button.Hide();
                this.Set_Constraints();
            }
            else if(isAdd == 2)
            {
                this.Text = "Edit Contract";
                this.ContractIDCB.Enabled = false;
            }
            this.SecondPartyIDCB.Enabled = false;
        }

        private void ContractIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void ContractID_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Add_Edit_Button_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@isAdd", this.IsAdd);
            Parameters.Add("@ID", Int32.Parse(this.ContractIDCB.Text));
            Parameters.Add("@Start_Date", this.Start_Date_Picker.Text);
            Parameters.Add("@End_Date", this.End_Date_Picker.Text);
            Parameters.Add("@Second_Party_ID", this.SecondPartyIDCB.Text);
            Parameters.Add("@Second_Party_Type", this.SecondPartyTypeCB.Text);
            Parameters.Add("@Content", Content_Text.Text);

            DBManager DBm = new DBManager();
            int Result = DBm.ExecuteNonQuery(StoredProcedures.Add_Update_Contracts, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved.");

                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string S;
                if (IsAdd == 1)
                    S = "User Added new Contract With ID: " + this.ContractIDCB.Text + ".";
                else if (IsAdd == 2)
                    S = "User Edited Contract With ID: " + this.ContractIDCB.Text + ".";
                else
                    S = "User Deleted Record From Contracts";
                MLK.InsertData(CurrentUser.UserName, S);
            }
            else
            {
                MessageBox.Show("Error");
            }
            this.Close();
        }


        public void SetDataBeforeEdit(DataGridView datagrid, int Ind)
        {
            this.ContractIDCB.Text = datagrid.Rows[Ind].Cells[0].Value.ToString();
            this.Start_Date_Picker.Text = datagrid.Rows[Ind].Cells[1].Value.ToString();
            this.End_Date_Picker.Text = datagrid.Rows[Ind].Cells[2].Value.ToString();
            this.SecondPartyIDCB.Text = datagrid.Rows[Ind].Cells[3].Value.ToString();
            this.SecondPartyTypeCB.Text = datagrid.Rows[Ind].Cells[4].Value.ToString();
            this.Content_Text.Text = datagrid.Rows[Ind].Cells[5].Value.ToString();
        }

        private void Delete_Contract_Button_Click(object sender, EventArgs e)
        {
            this.IsAdd = 3;
            this.Save_Add_Edit_Button_Click(sender, e);
        }

        private void SecondPartyTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SecondPartyIDCB.Enabled = true;
            string S = "";
            if (this.SecondPartyTypeCB.SelectedItem.ToString() == "Employee")
                S = "SELECT ESSN FROM Employee;";
            else if (this.SecondPartyTypeCB.SelectedItem.ToString() == "Player")
                S = "SELECT Kit_Number FROM Player;";
            else if (this.SecondPartyTypeCB.SelectedItem.ToString() == "Sponsor")
                S = "SELECT Company_ID FROM Companies;";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    this.SecondPartyIDCB.Items.Add(reader.GetString(0));
            reader.Close();
            this.Check();
        }

        private void Set_Constraints()
        {
            string S = "SELECT ID FROM Contracts;";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    S = reader.GetInt32(0).ToString();
                    for (int i = 0; i < this.ContractIDCB.Items.Count; i++)
                    {
                        if (this.ContractIDCB.Items.Contains(S))
                        {
                            this.ContractIDCB.Items.Remove(S);
                            i--;
                            continue;
                        }
                    }
                }
            reader.Close();
        }

        private void Check()
        {
            if (this.ContractIDCB.Text != "" && this.Start_Date_Picker.Text != "" && this.End_Date_Picker.Text != "" && this.Content_Text.Text != "" && this.SecondPartyIDCB.Text != "" && this.SecondPartyTypeCB.Text != "")
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

        private void SecondPartyIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Content_Text_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

    }
}
