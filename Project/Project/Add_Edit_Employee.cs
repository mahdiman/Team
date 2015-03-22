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
    public partial class Add_Edit_Employee : Form
    {
        int IsAdd;
        User CurrentUser = new User();
        public Add_Edit_Employee(int isAdd , User CurUsr)
        {
            InitializeComponent();
            this.CurrentUser = CurUsr;
            this.IsAdd = isAdd;
            if (isAdd == 1)
            {
                this.Text = "Add Employee";
                this.Delete_Employee.Hide();
            }
            else if(isAdd==2)
            {
                this.Text = "Edit Employee";
                this.ESSN_Text.Enabled = false;
            }

        }

        private void Add_Edit_Employee_Load(object sender, EventArgs e)
        {
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = Manager.myConnection;
            myCommand.CommandText = "SELECT ID FROM Job";
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    this.Job_CB.Items.Add(reader.GetInt32(0).ToString());
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Add_Edit_Button_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@isAdd", IsAdd);
            Parameters.Add("@Fname", this.First_Name_Text.Text);
            Parameters.Add("@MINIT", this.Middle_Name_Text.Text);
            Parameters.Add("@Lname", this.Last_Name_Text.Text);
            Parameters.Add("@Bdate", this.Birth_Date_Picker.Text);
            Parameters.Add("@ESSN", this.ESSN_Text.Text);
            Parameters.Add("@Address", this.Address_Text.Text);
            Parameters.Add("@E_Mail", this.E_Mail_Text.Text);
            Parameters.Add("@Mobile", this.Mobile_Text.Text);
            Parameters.Add("@Home_Phone", this.Home_Phone_Text.Text);
            Parameters.Add("@Nationality", this.Nationality_CB.Text);
            Parameters.Add("@Job_ID", Int32.Parse(this.Job_CB.Text));
            DBManager D = new DBManager();
            int Result = D.ExecuteNonQuery(StoredProcedures.Add_Update_Employee, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved.");

                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string S;
                if (IsAdd == 1)
                    S = "User Added new Employee With ESSN: " + this.ESSN_Text.Text + ".";
                else if (IsAdd == 2)
                    S = "User Edited Employee With ESSN: " + this.ESSN_Text.Text + ".";
                else
                    S = "User Deleted Record From Employees";
                MLK.InsertData(CurrentUser.UserName, S);

            }
            else
            {
                MessageBox.Show("Error");
            }
            this.Close();
        }

        private void Delete_Employee_Click(object sender, EventArgs e)
        {
            DialogResult DResult = MessageBox.Show("This action may affect some of sponsor and injuries information, Are you sure you want to proceed?", "Message", MessageBoxButtons.YesNo);
            if (DResult == DialogResult.Yes)
            {
                this.IsAdd = 3;
                this.Save_Add_Edit_Button_Click(sender, e);
                string S = "DELETE FROM Contracts WHERE SecondPartyID='" + this.ESSN_Text.Text + "' AND SecondPartyType='Employee';";
                DBManager Manager = new DBManager();
                SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
                myCommand.ExecuteNonQuery();
            }
        }
        public void SetDataBeforEdit(DataGridView datagrid, int Ind)
        {
            this.First_Name_Text.Text = datagrid.Rows[Ind].Cells[0].Value.ToString();
            this.Middle_Name_Text.Text = datagrid.Rows[Ind].Cells[1].Value.ToString();
            this.Last_Name_Text.Text = datagrid.Rows[Ind].Cells[2].Value.ToString();
            this.Birth_Date_Picker.Text = datagrid.Rows[Ind].Cells[3].Value.ToString();
            this.ESSN_Text.Text = datagrid.Rows[Ind].Cells[4].Value.ToString();
            this.Address_Text.Text = datagrid.Rows[Ind].Cells[5].Value.ToString();
            this.E_Mail_Text.Text = datagrid.Rows[Ind].Cells[6].Value.ToString();
            this.Mobile_Text.Text = datagrid.Rows[Ind].Cells[7].Value.ToString();
            this.Home_Phone_Text.Text = datagrid.Rows[Ind].Cells[8].Value.ToString();
            this.Nationality_CB.Text = datagrid.Rows[Ind].Cells[10].Value.ToString();
            this.Job_CB.Text = datagrid.Rows[Ind].Cells[9].Value.ToString();
        }

        private void ESSN_Text_TextChanged(object sender, EventArgs e)
        {
            if (this.IsAdd == 1 && this.ESSN_Text.Text.Length!=0)
            {
                string S = "SELECT ESSN FROM Employee WHERE ESSN ='" + this.ESSN_Text.Text + "';";
                DBManager Manager = new DBManager();
                SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows || this.ESSN_Text.Text.Length < 11)
                {
                    this.Check_Label.Text = "Invalid ESSN";
                }
                else
                {
                    this.Check_Label.Text = "Valid ESSN";
                    this.Check();
                }
                reader.Close();
            }
        }

        private void Check()
        {
            if (this.First_Name_Text.Text != "" && this.Last_Name_Text.Text != "" && this.Job_CB.Text != "" && this.ESSN_Text.Text.Length >=11)
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

        private void Job_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }
    }
}
