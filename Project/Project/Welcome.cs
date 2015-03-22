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
    public partial class Welcome : Form
    {

        User CurrentUser = new User();

        public Welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            // Login Code Starts Here ...
            DBManager Manager = new DBManager();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = Manager.myConnection;
            myCommand.CommandText = StoredProcedures.Login;
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@username", User_Name.Text);
            myCommand.Parameters.AddWithValue("@password", Pass_Word.Text);
            SqlDataReader myReader = myCommand.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {
                count++;
                CurrentUser.Name = myReader.GetString(2);
                CurrentUser.Type = myReader.GetString(3);
                CurrentUser.PassWord = myReader.GetString(1);
                CurrentUser.UserName = myReader.GetString(0);
  
            }
            if (count == 1)
            {
                Hide();
                Main_Menu MainMenu = new Main_Menu(CurrentUser);
                MainMenu.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password.");
                this.User_Name.Text = "";
                this.Pass_Word.Text = "";
            }

            // Login Code Ends Here ...
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult DResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (DResult == DialogResult.Yes)
            {
                Close();
            }
        }
        private void User_Name_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Pass_Word_TextChanged(object sender, EventArgs e)
        {
            this.Check();
        }

        private void Check()
        {
            if (this.Pass_Word.Text != "" && this.User_Name.Text != "")
                this.Login_Button.Enabled = true;
            else
                this.Login_Button.Enabled = false;
        }
    }
}
