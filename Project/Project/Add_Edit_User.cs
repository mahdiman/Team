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
    public partial class Add_Edit_User : Form
    {
        int IsAdd;
        Main_Menu Menu;
        User CurrentUser = new User();
        Settings sett;
        public Add_Edit_User(int isAdd , User CurrUser , Main_Menu menu , Settings S)
        {
            InitializeComponent();
            this.Menu = menu;
            this.CurrentUser = CurrUser;
            sett = S;
            IsAdd = isAdd;
            if (isAdd == 1)
            {
                this.Text = "Add User";
                this.Delete.Hide();
            }
            else
            {
                this.Text = "Edit User";
                this.HandleText.Enabled = false;
                this.PassWordText.Enabled = false;
                this.NameText.Enabled = false;
            }
        }


        public void SetDataBeforeEdit(DataGridView dgv , int Ind)
        {
            this.HandleText.Text = dgv.Rows[Ind].Cells[0].Value.ToString();
            this.PassWordText.Text = dgv.Rows[Ind].Cells[1].Value.ToString();
            this.NameText.Text = dgv.Rows[Ind].Cells[3].Value.ToString();
            this.PrivilegesCB.Text = dgv.Rows[Ind].Cells[2].Value.ToString();
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Parameter", IsAdd);
            Parameters.Add("@Username", this.HandleText.Text);
            Parameters.Add("@Password", this.PassWordText.Text);
            Parameters.Add("@Name", this.NameText.Text);
            Parameters.Add("@Type", this.PrivilegesCB.Text);
            DBManager D = new DBManager();
            int Result = D.ExecuteNonQuery(StoredProcedures.Add_Edit_Delete_User, Parameters);
            if (Result != 0)
            {
                if (IsAdd < 3)
                    MessageBox.Show("Changes Saved.");
                else
                {
                    MessageBox.Show("Record Deleted.");
                    if(this.CurrentUser.UserName == this.HandleText.Text)
                    {
                        this.sett.Hide();
                        this.sett.Close();
                        this.Menu.Hide();
                        this.Menu.Close();
                        this.Hide();
                        this.Close();
                        Welcome A = new Welcome();
                        A.ShowDialog();
                    }
                }
            }
            else
                MessageBox.Show("Error");
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            IsAdd = 3;
            this.Save_Click(sender, e);
        }

        private void Add_Edit_User_Load(object sender, EventArgs e)
        {

        }

        private void HandleText_TextChanged(object sender, EventArgs e)
        {
            if (this.IsAdd == 1 && this.HandleText.Text.Length != 0)
            {
                string S = "SELECT UserName FROM User_Login WHERE UserName ='" + this.HandleText.Text + "';";
                DBManager Manager = new DBManager();
                SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    this.Check.Text = "Invalid Handle";
                }
                else
                {
                    this.Check.Text = "Valid Handle";
                    this.Check_();
                }
                reader.Close();
            }
        }

        private void Check_()
        {
            if (this.HandleText.Text != "" && this.PassWordText.Text != "" && this.NameText.Text != "" && this.PrivilegesCB.Text != "")
                this.Save.Enabled = true;
            else this.Save.Enabled = false;
        }

        private void PassWordText_TextChanged(object sender, EventArgs e)
        {
            this.Check_();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            this.Check_();
        }

        private void PrivilegesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check_();
        }
    }
}
