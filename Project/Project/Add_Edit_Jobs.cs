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
    public partial class Add_Edit_Jobs : Form
    {
        int IsAdd;
        User CurrentUser = new User();
        public Add_Edit_Jobs(int isAdd , User CurUsr)
        {
            InitializeComponent();
            this.CurrentUser = CurUsr;
            IsAdd = isAdd;
            this.IDCB.Text = "";
            if(isAdd == 1)
            {
                this.Text = "Add Job";
                this.Delete.Hide();
                this.Set_Constraints();
            }
            else if(isAdd ==2)
            {
                this.Text = "Edit Job";
                this.IDCB.Enabled = false;
            }
            this.MngrIDCB.Enabled = true;
        }
        public void SetDataBeforeEdit(DataGridView D , int Ind)
        {
            this.IDCB.Text = D.Rows[Ind].Cells[0].Value.ToString();
            this.JobNameText.Text = D.Rows[Ind].Cells[1].Value.ToString();
            this.JobDescribtionText.Text = D.Rows[Ind].Cells[2].Value.ToString();
            this.MngrIDCB.Text = D.Rows[Ind].Cells[3].Value.ToString();
        }

        private void Add_Edit_Jobs_Load(object sender, EventArgs e)
        {
            string Sql = "SELECT ID FROM Job";
            DBManager D = new DBManager();
            SqlCommand cmd = new SqlCommand(Sql, D.myConnection);
            SqlDataReader R = cmd.ExecuteReader();
            while (R.Read())
            {
                if(!(this.IsAdd==2 && this.IDCB.Text == R.GetInt32(0).ToString()))
                    this.MngrIDCB.Items.Add(R.GetInt32(0));
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
                Dictionary<string, object> Parameters = new Dictionary<string, object>();
                Parameters.Add("@Parameter", IsAdd);
                Parameters.Add("@ID", this.IDCB.Text);
                Parameters.Add("@Name", this.JobNameText.Text);
                Parameters.Add("@Describtion", this.JobDescribtionText.Text);
                Parameters.Add("@MngrJobID", this.MngrIDCB.Text);
                DBManager D = new DBManager();
                int Result = D.ExecuteNonQuery(StoredProcedures.ADD_EDIT_DELETE_Job, Parameters);
                if (Result!=0)
                {
                    MessageBox.Show("Changes Saved.");

                    Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                    string S;
                    if (IsAdd == 1)
                        S = "User Added new Job With ID: " + this.IDCB.Text + ".";
                    else if (IsAdd == 2)
                        S = "User Edited Job With ID: " + this.IDCB.Text + ".";
                    else
                        S = "User Deleted Record From Job";
                    MLK.InsertData(CurrentUser.UserName, S);
                }
                else
                {
                  MessageBox.Show("Erro");
                }
                this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult DResult = MessageBox.Show("This action may affect some of employees information, Are you sure you want to proceed?", "Message", MessageBoxButtons.YesNo);
            if (DResult == DialogResult.Yes)
            {
                this.IsAdd = 3;
                this.Save_Click(sender, e);
            }
        }


        private void Set_Constraints()
        {
            string S = "SELECT ID FROM Job;";
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
            if (this.IDCB.Text != "" && this.JobNameText.Text != "")
                this.Save.Enabled = true;
            else
                this.Save.Enabled = false;
        }

        private void IDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void JobNameText_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }
    }
}
