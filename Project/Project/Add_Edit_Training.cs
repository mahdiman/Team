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

    public partial class Add_Edit_Training : Form
    {
        int IsAdd;
        User CurrentUser = new User();

        public Add_Edit_Training(int isAdd , User CurUsr)
        {
            InitializeComponent();
            this.CurrentUser = CurUsr;
            this.IsAdd = isAdd;
            if (isAdd == 1)
            {
                this.Text = "Add Training Details";
                this.Delete_Training_Button.Hide();
                this.Set_Constraints();
            }
            else if (isAdd == 2)
            {
                this.Text = "Edit Training";
                this.TrainingIDCB.Enabled = false;
            }

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Add_Edit_Button_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", Int32.Parse(this.TrainingIDCB.Text));
            Parameters.Add("@isAdd", this.IsAdd);
            Parameters.Add("@Date", this.Start_Date_Picker.Text);
            Parameters.Add("@Period", Int32.Parse(this.Period_Text.Text));
            Parameters.Add("@PlayGround", this.PlayGround_Text.Text);
            Parameters.Add("@Country", this.Country_CB.Text);
            Parameters.Add("@Type", Int32.Parse(this.Training_Type_CB.Text));

            DBManager DBm = new DBManager();


            int Result = DBm.ExecuteNonQuery(StoredProcedures.Add_Update_Training, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved");

                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string S;
                if (IsAdd == 1)
                    S = "User Added new Training With ID: " + this.TrainingIDCB.Text + ".";
                else if (IsAdd == 2)
                    S = "User Edited Training With ID: " + this.TrainingIDCB.Text + ".";
                else
                    S = "User Deleted Record From Training Schedule";
                MLK.InsertData(CurrentUser.UserName, S);

            }
            else
                MessageBox.Show("Error");
            this.Close();
        }


        private void Add_Edit_Training_Load(object sender, EventArgs e)
        {
            string S = "SELECT ID FROM Training_Type ; ";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    this.Training_Type_CB.Items.Add(reader.GetInt32(0).ToString());
            reader.Close();
        }

        public void SetDataBeforEdit(DataGridView datagrid, int Ind)
        {
            this.TrainingIDCB.Text = datagrid.Rows[Ind].Cells[0].Value.ToString();
            this.Start_Date_Picker.Text = datagrid.Rows[Ind].Cells[1].Value.ToString();
            this.Period_Text.Text = datagrid.Rows[Ind].Cells[2].Value.ToString();
            this.PlayGround_Text.Text = datagrid.Rows[Ind].Cells[3].Value.ToString();
            this.Country_CB.Text = datagrid.Rows[Ind].Cells[4].Value.ToString();
            this.Training_Type_CB.Text = datagrid.Rows[Ind].Cells[5].Value.ToString();
        }

        private void Delete_Training_Button_Click(object sender, EventArgs e)
        {
            IsAdd = 3;
            this.Save_Add_Edit_Button_Click(sender, e);
        }

        private void Set_Constraints()
        {
            string S = "SELECT ID FROM Training;";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    S = reader.GetInt32(0).ToString();
                    for (int i = 0; i < this.TrainingIDCB.Items.Count; i++)
                    {
                        if (this.TrainingIDCB.Items.Contains(S))
                        {
                            this.TrainingIDCB.Items.Remove(S);
                            i--;
                            continue;
                        }
                    }
                }
            reader.Close();
        }
        private void Check()
        {
            if (this.Start_Date_Picker.Text != "" && this.TrainingIDCB.Text != "" && this.Country_CB.Text != "" && this.Training_Type_CB.Text != "" && this.Period_Text.Text != "")
                this.Save_Add_Edit_Button.Enabled = true;
            else
                this.Save_Add_Edit_Button.Enabled = false;
        }

        private void TrainingIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Start_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Training_Type_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Country_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Period_Text_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

    }
}
