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
    public partial class Add_Edit_Training_Type : Form
    {
        int IsAdd;
        User CurrentUser = new User();
        public Add_Edit_Training_Type(int isAdd , User CurUsr)
        {
            IsAdd = isAdd;
            this.CurrentUser = CurUsr;
            InitializeComponent();
            if(isAdd == 1)
            {
                this.Text = "Add Training";
                this.Delete.Hide();
            }
            else if(isAdd ==2)
            {
                this.Text = "Edit Training";
                this.IDCB.Enabled = false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@isAdd", IsAdd);
            Parameters.Add("@ID", this.IDCB.Text);
            Parameters.Add("@Name", this.Name_Text.Text);
            Parameters.Add("@Describtion", this.Describtion_Text.Text);
            DBManager D = new DBManager();
            int Result = D.ExecuteNonQuery(StoredProcedures.Add_Update_Training_Type, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved.");


                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string S;
                if (IsAdd == 1)
                    S = "User Added new Trainig Type With ID: " + this.IDCB.Text + ".";
                else if (IsAdd == 2)
                    S = "User Edited Training Type With ID: " + this.IDCB.Text + ".";
                else
                    S = "User Deleted Record From Trainig Type";
                MLK.InsertData(CurrentUser.UserName, S);

            }
            else
            {
                MessageBox.Show("Error");
            }
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult DResult = MessageBox.Show("This action may affect some of Training information, Are you sure you want to proceed?", "Message", MessageBoxButtons.YesNo);
            if (DResult == DialogResult.Yes)
            {
                this.IsAdd = 3;
                this.Save_Click(sender, e);
            }
        }

        public void SetDataBeforeEdit(DataGridView D, int Ind)
        {
            this.IDCB.Text = D.Rows[Ind].Cells[0].Value.ToString();
            this.Name_Text.Text = D.Rows[Ind].Cells[1].Value.ToString();
            this.Describtion_Text.Text = D.Rows[Ind].Cells[2].Value.ToString();
        }

        private void Set_Constraints()
        {
            string S = "SELECT ID FROM Training_Type;";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    S = reader.GetInt32(0).ToString();
                    for (int i = 0; i < this.IDCB.Items.Count; i++)
                    {
                        if (this.IDCB.Items.Contains(S))
                        {
                            this.IDCB.Items.Remove(S);
                            i--;
                            continue;
                        }
                    }
                }
            reader.Close();
        }

        private void Check()
        {
            if (this.IDCB.Text != "" && this.Name_Text.Text != "")
                this.Save.Enabled = true;
            else
                this.Save.Enabled = false;
        }

        private void IDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Name_Text_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

    }
}
