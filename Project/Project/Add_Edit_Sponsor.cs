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
    public partial class Add_Edit_Sponsor : Form
    {
        int IsAdd;
        User CurrentUser = new User();
        public Add_Edit_Sponsor(int isAdd , User CurUsr)
        {
            InitializeComponent();
            this.CurrentUser = CurUsr;
            this.IsAdd = isAdd;
            if (isAdd == 1)
            {
                this.Text = "Add Company";
                this.Delete_Company.Hide();
                this.Set_Constraints();
            }
            else if (isAdd == 2)
            {
                this.Text = "Edit Company";
                this.companyIDCB.Enabled = false;
            }
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Edit_Sponsor_Load(object sender, EventArgs e)
        {
            string S = "SELECT ESSN FROM Employee ; ";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    this.OurAgent_CB.Items.Add(reader.GetString(0));
            reader.Close();
        }

        private void Save_Add_Edit_Button_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@isAdd", this.IsAdd);
            Parameters.Add("@ID", this.companyIDCB.Text);
            Parameters.Add("@Name", this.Name_Text.Text);
            Parameters.Add("@Activity", this.Activity_Text.Text);
            Parameters.Add("@Our_Agent", this.OurAgent_CB.Text);
            Parameters.Add("@Address", this.Address_Text.Text);
            Parameters.Add("@E_Mail", this.E_Mail_Text.Text);
            Parameters.Add("@Contact_Agent", this.ContactAgent_Text.Text);

            DBManager DBm = new DBManager();
            int Result = DBm.ExecuteNonQuery(StoredProcedures.Add_Update_Sponsor, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved.");


                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string S;
                if (IsAdd == 1)
                    S = "User Added new Sponsor With ID: " + this.companyIDCB.Text + ".";
                else if (IsAdd == 2)
                    S = "User Edited Sponsor With ID: " + this.companyIDCB.Text + ".";
                else
                    S = "User Deleted Record From Sponsors";
                MLK.InsertData(CurrentUser.UserName, S);

            }
            else
            {
                MessageBox.Show("Error");
            }
            this.Close();
        }

        private void Delete_Company_Click(object sender, EventArgs e)
        {
            this.IsAdd = 3;
            this.Save_Add_Edit_Button_Click(sender, e);

            string S = "DELETE FROM Contracts WHERE SecondPartyID='" + this.companyIDCB.Text + "' AND SecondPartyType='Sponsor';";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            myCommand.ExecuteNonQuery();
        }
        public void SetDataBeforeEdit(DataGridView datagrid, int Ind)
        {
            this.companyIDCB.Text = datagrid.Rows[Ind].Cells[0].Value.ToString();
            this.Name_Text.Text = datagrid.Rows[Ind].Cells[1].Value.ToString();
            this.Activity_Text.Text = datagrid.Rows[Ind].Cells[2].Value.ToString();
            this.OurAgent_CB.Text = datagrid.Rows[Ind].Cells[3].Value.ToString();
            this.Address_Text.Text = datagrid.Rows[Ind].Cells[4].Value.ToString();
            this.E_Mail_Text.Text = datagrid.Rows[Ind].Cells[5].Value.ToString();
            this.ContactAgent_Text.Text = datagrid.Rows[Ind].Cells[6].Value.ToString();
        }

        private void Set_Constraints()
        {
            string S = "SELECT Company_ID FROM Companies;";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    S = reader.GetString(0).ToString();
                    for (int i = 0; i < this.companyIDCB.Items.Count; i++)
                    {
                        if (this.companyIDCB.Items.Contains(S))
                        {
                            this.companyIDCB.Items.Remove(S);
                            i--;
                            continue;
                        }
                    }
                }
            reader.Close();
        }

        private void Check()
        {
            if (this.companyIDCB.Text != "" && this.Name_Text.Text != "" && this.OurAgent_CB.Text != "" && this.ContactAgent_Text.Text != "")
                this.Save_Add_Edit_Button.Enabled = true;
            else this.Save_Add_Edit_Button.Enabled = false;
        }

        private void Name_Text_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void companyIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void ContactAgent_Text_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void OurAgent_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }
    }
}