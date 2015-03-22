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
    public partial class Add_Edit_Absent_Players : Form
    {
        public Add_Edit_Absent_Players()
        {
            InitializeComponent();
        }

        private void Add_Edit_Absent_Players_Load(object sender, EventArgs e)
        {
            string SQL_Query = "Select Kit_Number FROM Player ORDER BY Kit_Number;";

            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = SQL_Query;
            myCommand.Connection = Manager.myConnection;
            SqlDataReader Reader = myCommand.ExecuteReader();

            while(Reader.Read())
            {
                string S = Reader.GetString(0).ToString();
                this.Check_Absent.Items.Add(S);
            }

            Reader.Close();
            SQL_Query = "SELECT ID FROM Training ORDER BY ID ;";
            myCommand.CommandText = SQL_Query;
            Reader = myCommand.ExecuteReader();
            while (Reader.Read())
            {
                string S = Reader.GetInt32(0).ToString();
                this.Training_CB.Items.Add(S);
            }


        }

        private void Save_Click(object sender, EventArgs e)
        {
            string S = "DELETE FROM Training_Absence WHERE Training_ ='" + this.Training_CB.Text + "';";
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand(S , Manager.myConnection);
            myCommand.ExecuteNonQuery();
            foreach (object itemChecked in Check_Absent.CheckedItems)
            {
                try
                {
                    myCommand.CommandText = "INSERT INTO Training_Absence (Player_ID , Training_) VALUES ('" + itemChecked.ToString() + "','" + this.Training_CB.Text + "');";
                    myCommand.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error");
                    return;
                }
            }
            MessageBox.Show("Changes Saved");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Training_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Training_CB.Text != "")
            {
                string S = "SELECT Player_ID FROM Training_Absence WHERE Training_ ='" + this.Training_CB.Text + "';";
                DBManager Manager = new DBManager();
                SqlCommand myCommand = new SqlCommand();
                myCommand.CommandText = S;
                myCommand.Connection = Manager.myConnection;
                SqlDataReader Reader = myCommand.ExecuteReader();


                for (int i = 0; i < Check_Absent.Items.Count; i++)
                {
                    Check_Absent.SetItemChecked(i, false);
                }

                while (Reader.Read())
                {
                    string str = Reader.GetString(0);
                    if (Check_Absent.Items.Contains(str))
                    {
                        SetItemChecked(str);
                    }
                }

                Reader.Close();
                this.Save.Enabled = true;
            }
            else
                this.Save.Enabled = false;
        }



        private void SetItemChecked(string item)
        {
            int index = GetItemIndex(item);

            if (index < 0) return;

            this.Check_Absent.SetItemChecked(index, true);
        }

        private int GetItemIndex(string item)
        {
            int index = 0;
            foreach (object o in this.Check_Absent.Items)
            {
                if (item == o.ToString())
                    return index;
                index++;
            }

            return -1;
        }
    }
}
