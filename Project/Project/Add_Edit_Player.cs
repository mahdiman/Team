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
    public partial class Add_Edit_Player : Form
    {

        int IsAdd;
        User CurrentUser = new User();
        public Add_Edit_Player(int B , User CurUsr)
        {
            IsAdd = B;
            this.CurrentUser = CurUsr;
            InitializeComponent();
            if (B==1)
            {
                this.Text = "Add New Player";
                this.Delete_Player.Hide();
                this.Set_Constraints();
            }
            else
            {
                this.Text = "Edit Player";
            }
        }

        private void Add_Edit_Player_Load(object sender, EventArgs e)
        {

        }
        public void SetDataBeforEdit(DataGridView datagrid , int Ind)
        {
           this.First_Name_Text.Text = datagrid.Rows[Ind].Cells[0].Value.ToString();
           this.Middle_Name_Text.Text = datagrid.Rows[Ind].Cells[1].Value.ToString();
           this.Last_Name_Text.Text = datagrid.Rows[Ind].Cells[2].Value.ToString();
           this.Kit_Number_CB.Text = datagrid.Rows[Ind].Cells[3].Value.ToString();
           this.Position_CB.Text = datagrid.Rows[Ind].Cells[4].Value.ToString();
           this.Address_Text.Text = datagrid.Rows[Ind].Cells[5].Value.ToString();
           this.E_Mail_Text.Text = datagrid.Rows[Ind].Cells[6].Value.ToString();
           this.Mobile_Text.Text = datagrid.Rows[Ind].Cells[7].Value.ToString();
           this.Home_Phone_Text.Text = datagrid.Rows[Ind].Cells[8].Value.ToString();
           this.Birth_Date_Picker.Text = datagrid.Rows[Ind].Cells[9].Value.ToString();
           this.Nationality_CB.Text = datagrid.Rows[Ind].Cells[10].Value.ToString();
           this.Height_CB.Text = datagrid.Rows[Ind].Cells[11].Value.ToString();
           this.Weight_CB.Text = datagrid.Rows[Ind].Cells[12].Value.ToString();
        }

        private void Save_Add_Edit_Button_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@isAdd", this.IsAdd);
            Parameters.Add("@FName", First_Name_Text.Text);
            Parameters.Add("@MINT", Middle_Name_Text.Text);
            Parameters.Add("@LName", Last_Name_Text.Text);
            Parameters.Add("@Adrees", Address_Text.Text);
            Parameters.Add("@E_Mail", E_Mail_Text.Text);
            Parameters.Add("@Mobile", Mobile_Text.Text);
            Parameters.Add("@Home_Phone", Home_Phone_Text.Text);
            Parameters.Add("@Nationality", Nationality_CB.Text);
            Parameters.Add("@BDATE", this.Birth_Date_Picker.Text);
            Parameters.Add("@Kit_Number", Kit_Number_CB.Text);
            Parameters.Add("@Position", Position_CB.Text);
            Parameters.Add("@Height", Height_CB.Text);
            Parameters.Add("@Weight", Weight_CB.Text);
            DBManager DBm = new DBManager();
            int Result = DBm.ExecuteNonQuery(StoredProcedures.Add_Update_Player, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved");

                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string S;
                if (IsAdd == 1)
                    S = "User Added new Player With Kit Number: " + this.Kit_Number_CB.Text + ".";
                else if (IsAdd == 2)
                    S = "User Edited Player With Kit Number: " + this.Kit_Number_CB.Text + ".";
                else
                    S = "User Deleted Record From Players";
                MLK.InsertData(CurrentUser.UserName, S);
            }
            else
                MessageBox.Show("Error");
            this.Close();
        }

        private void Delete_Player_Click(object sender, EventArgs e)
        {
            this.IsAdd = 3;
            this.Save_Add_Edit_Button_Click(sender,e);

            string S = "DELETE FROM Contracts WHERE SecondPartyID='" + this.Kit_Number_CB.Text + "' AND SecondPartyType='Player';";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            myCommand.ExecuteNonQuery();

        }

        private void Set_Constraints()
        {
            string S = "SELECT Kit_Number FROM Player;";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    S = reader.GetString(0).ToString();
                    for (int i = 0; i < this.Kit_Number_CB.Items.Count; i++)
                    {
                        if (this.Kit_Number_CB.Items.Contains(S))
                        {
                            this.Kit_Number_CB.Items.Remove(S);
                            i--;
                            continue;
                        }
                    }
                }
            reader.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Check()
        {
            if (this.First_Name_Text.Text != "" && this.Last_Name_Text.Text != "" && this.Kit_Number_CB.Text != "")
                this.Save_Add_Edit_Button.Enabled = true;
            else
                this.Save_Add_Edit_Button.Enabled = false;
        }

        private void First_Name_Text_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Last_Name_Text_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        

        private void Kit_Number_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }
    }
}
