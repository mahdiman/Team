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
    public partial class Add_Edit_Performance : Form
    {
        int IsAdd;
        public Add_Edit_Performance(int isAdd)
        {
            InitializeComponent();
            IsAdd = isAdd;
            if (isAdd == 1)
            {
                this.Text = "Add Record";
                this.Delete.Hide();
                this.Set_Constraints();
            }
            else
            {
                this.Text = "Edit Record";
                this.IDCB.Enabled = false;
            }
        }

        private void Save_Add_Edit_Button_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@isAdd", IsAdd);
            Parameters.Add("@ID", Int32.Parse(this.IDCB.Text));
            Parameters.Add("@Attacking", Int32.Parse(this.Attacking_CB.Text));
            Parameters.Add("@Defending", Int32.Parse(this.Defending_CB.Text));
            Parameters.Add("@Finishing", Int32.Parse(this.Finishing_CB.Text));
            Parameters.Add("@Top_Speed", Int32.Parse(this.Top_Speed_CB.Text));
            Parameters.Add("@Acceleration", Int32.Parse(this.Acceleration_CB.Text));
            Parameters.Add("@Goal_Keeping", Int32.Parse(this.Goal_Keeping_CB.Text));
            Parameters.Add("@Team_Work", Int32.Parse(this.Team_Work_CB.Text));
            Parameters.Add("@Kick_Power", Int32.Parse(this.Kick_Power_CB.Text));
            Parameters.Add("@Measure_Date", this.Measure_Date_Picker.Text);
            Parameters.Add("@Kit", this.KitCB.Text);
            DBManager D = new DBManager();
            int Result = D.ExecuteNonQuery(StoredProcedures.Add_Update_Performance, Parameters);
            if (Result != 0)
            {
                MessageBox.Show("Changes Saved.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
                this.Close();
            }
        }


        public void SetDataBeforEdit(DataGridView datagrid, int Ind)
        {
            this.IDCB.Text = datagrid.Rows[Ind].Cells[0].Value.ToString();
            this.KitCB.Text = datagrid.Rows[Ind].Cells[1].Value.ToString();
            this.Measure_Date_Picker.Text = datagrid.Rows[Ind].Cells[2].Value.ToString();
            this.Attacking_CB.Text = datagrid.Rows[Ind].Cells[3].Value.ToString();
            this.Defending_CB.Text = datagrid.Rows[Ind].Cells[4].Value.ToString();
            this.Finishing_CB.Text = datagrid.Rows[Ind].Cells[5].Value.ToString();
            this.Top_Speed_CB.Text = datagrid.Rows[Ind].Cells[6].Value.ToString();
            this.Acceleration_CB.Text = datagrid.Rows[Ind].Cells[7].Value.ToString();
            this.Goal_Keeping_CB.Text = datagrid.Rows[Ind].Cells[8].Value.ToString();
            this.Team_Work_CB.Text = datagrid.Rows[Ind].Cells[9].Value.ToString();
            this.Kick_Power_CB.Text = datagrid.Rows[Ind].Cells[10].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.IsAdd = 3;
            this.Save_Add_Edit_Button_Click(sender, e);
        }

        private void Add_Edit_Performance_Load(object sender, EventArgs e)
        {
            string S = "SELECT Kit_Number FROM Player ; ";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S, Manager.myConnection);
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    this.KitCB.Items.Add(reader.GetString(0));
            reader.Close();
        }


        private void Set_Constraints()
        {
            string S = "SELECT ID FROM Performance;";
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

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Check()
        {
            if (this.Attacking_CB.Text != "" && this.Defending_CB.Text != "" && this.Finishing_CB.Text != "" &&
                this.Top_Speed_CB.Text != "" && this.Acceleration_CB.Text != "" && this.Team_Work_CB.Text != "" &&
                this.Goal_Keeping_CB.Text != "" && this.Kick_Power.Text != "" && this.IDCB.Text != "" && this.Measure_Date_Picker.Text != "" &&
                this.KitCB.Text != "")
                this.Save_Add_Edit_Button.Enabled = true;
            else
                this.Save_Add_Edit_Button.Enabled = false;
        }

        private void IDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Measure_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void KitCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Attacking_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Defending_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Finishing_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Top_Speed_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Acceleration_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Goal_Keeping_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Team_Work_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Kick_Power_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Check();
        }

    }
}
