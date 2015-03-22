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
    public partial class Settings : Form
    {
        User CurrentUser = new User();
        Main_Menu Menu ;
        public Settings(User CurrentUsr , Main_Menu menu)
        {
            InitializeComponent();
            this.CurrentUser = CurrentUsr;
            this.Menu = menu;
            this.Username.Text = this.CurrentUser.UserName;
            this.Type.Text = this.CurrentUser.Type;
            this.NameText.Text = this.CurrentUser.Name;
            this.Old_Label.Hide(); 
            this.New_Label.Hide();
            this.Repeat_Label.Hide();
            this.RepeatText.Hide();
            this.NewText.Hide();
            this.OldText.Hide();
            this.ApplyPrivileges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Old_Label.Show();
            this.New_Label.Show();
            this.Repeat_Label.Show();
            this.RepeatText.Show();
            this.NewText.Show();
            this.OldText.Show();
        }

        private void Save_Me_Tab_Page_Click(object sender, EventArgs e)
        {
            if(this.NameText.Text != "" && this.NewText.Text != "" && this.OldText.Text != "" && this.RepeatText.Text!="")
            {


                Dictionary<string, object> Parameters = new Dictionary<string, object>();
                Parameters.Add("@Parameter", 2);
                Parameters.Add("@Username", this.CurrentUser.UserName);
                Parameters.Add("@Password", this.RepeatText.Text);
                Parameters.Add("@Name", this.NameText.Text);
                Parameters.Add("@Type", this.CurrentUser.Type);
                DBManager D = new DBManager();
                int Result = D.ExecuteNonQuery(StoredProcedures.Add_Edit_Delete_User, Parameters);
                if (Result != 0)
                {
                    CurrentUser.Name = NameText.Text;
                    CurrentUser.PassWord = RepeatText.Text;
                    MessageBox.Show("Changes Saved");
                    this.Cancel_Me_Tab_Page_Click(sender, e);
                }
                else
                    MessageBox.Show("Error");

            }
        }

        private void OldText_TextChanged(object sender, EventArgs e)
        {
            if(OldText.Text == this.CurrentUser.PassWord)
            {
                this.OldCheck.Text = "Right";
                this.NewText.Enabled = true;
            }
            else
            {
                this.OldCheck.Text = "Wrong";
                this.NewText.Enabled = false;
                this.RepeatText.Enabled = false;
            }
        }

        private void NewText_TextChanged(object sender, EventArgs e)
        {
            if (NewText.Text != "")
            {
                this.RepeatText.Enabled = true;
                if (NewText.Text.Length < 8)
                    this.Strenght_Check.Text = "Weak";
                else if (NewText.Text.Length < 16)
                    this.Strenght_Check.Text = "Meduim";
                else
                    this.Strenght_Check.Text = "Strong";

            }
            else
                this.RepeatText.Enabled = false;
        }

        private void RepeatText_TextChanged(object sender, EventArgs e)
        {
            if (this.RepeatText.Text == this.NewText.Text)
            {
                this.NewCheck.Text = "Right";
            }
            else
                this.NewCheck.Text = "Wrong";
        }

        private void Cancel_Me_Tab_Page_Click(object sender, EventArgs e)
        {
            this.NewCheck.Text = this.OldCheck.Text = this.OldText.Text = this.NewText.Text = this.RepeatText.Text = this.Strenght_Check.Text = "";
            this.NameText.Text = CurrentUser.Name;
        }

        private void Type_Label_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Add_User_Click(object sender, EventArgs e)
        {
            Add_Edit_User AddUser = new Add_Edit_User(1 , CurrentUser,Menu,this);
            AddUser.ShowDialog();
            this.Refresh();
        }

        private void Edit_User_Click(object sender, EventArgs e)
        {
            if (this.Users_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_User EditUser = new Add_Edit_User(2 , CurrentUser,Menu,this);
                EditUser.SetDataBeforeEdit(this.Users_List_View, this.Users_List_View.CurrentRow.Index);
                EditUser.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE User To Edit");
        }

        private void Refresh()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Parameter", 9);
            DBManager D = new DBManager();
            this.Users_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Users_List_View.Refresh();
            Parameters.Clear();
            Parameters.Add("@Parameter", 10);
            this.Jobs_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Jobs_List_View.Refresh();
            Parameters.Clear();
            Parameters.Add("@Parameter", 11);
            this.Chanmpionship_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Chanmpionship_List_View.Refresh();
            Parameters.Clear();
            Parameters.Add("@Parameter", 12);
            this.Injury_Type_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Injury_Type_List_View.Refresh();
            Parameters.Clear();
            Parameters.Add("@Parameter", 13);
            this.Training_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Training_List_View.Refresh();
            Parameters.Clear();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Job_Click(object sender, EventArgs e)
        {
            Add_Edit_Jobs AddJob = new Add_Edit_Jobs(1, CurrentUser);
            AddJob.ShowDialog();
            this.Refresh();
        }

        private void Edit_Job_Click(object sender, EventArgs e)
        {
            if (this.Jobs_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Jobs Editjob = new Add_Edit_Jobs(2, CurrentUser);
                Editjob.SetDataBeforeEdit(this.Jobs_List_View, this.Jobs_List_View.CurrentRow.Index);
                Editjob.ShowDialog();
                Refresh();
            }
            else
                MessageBox.Show("Select ONE Job To Edit");
        }

        private void Add_Champioship_Click(object sender, EventArgs e)
        {
            Add_Edit_Champ_Type AddChampTyp = new Add_Edit_Champ_Type(1, CurrentUser);
            AddChampTyp.ShowDialog();
            this.Refresh();
        }

        private void Edit_Champioship_Click(object sender, EventArgs e)
        {
            if (this.Chanmpionship_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Champ_Type EditChampType = new Add_Edit_Champ_Type(2, CurrentUser);
                EditChampType.SetDataBeforeEdit(this.Chanmpionship_List_View, this.Chanmpionship_List_View.CurrentRow.Index);
                EditChampType.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");
        }

        private void Add_Injury_Click(object sender, EventArgs e)
        {
            Add_Edit_Injury_Type AddInjType = new Add_Edit_Injury_Type(1, CurrentUser);
            AddInjType.ShowDialog();
            this.Refresh();
        }

        private void Edit_Injury_Click(object sender, EventArgs e)
        {
            if (this.Injury_Type_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Injury_Type EditInjType = new Add_Edit_Injury_Type(2, CurrentUser);
                EditInjType.SetDataBeforeEdit(this.Injury_Type_List_View, this.Injury_Type_List_View.CurrentRow.Index);
                EditInjType.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");
        }

        private void Add_Training_Click(object sender, EventArgs e)
        {
            Add_Edit_Training_Type AddTrainType = new Add_Edit_Training_Type(1, CurrentUser);
            AddTrainType.ShowDialog();
            this.Refresh();
        }

        private void Edit_Training_Click(object sender, EventArgs e)
        {
            if (this.Training_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Training_Type EditTrainType = new Add_Edit_Training_Type(2, CurrentUser);
                EditTrainType.SetDataBeforeEdit(this.Training_List_View, this.Training_List_View.CurrentRow.Index);
                EditTrainType.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");
        }

        private void ApplyPrivileges()
        {
            if (this.CurrentUser.Type == "Add Employee")
            {
                this.Settings_Tab_Group.TabPages.Remove(this.UsersTabPage);
                this.Edit_Training.Enabled = this.Edit_Job.Enabled = this.Edit_Injury.Enabled =
                this.Edit_Champioship.Enabled = false;
            }

            else if (this.CurrentUser.Type == "Edit Employee")
            {
                this.Settings_Tab_Group.TabPages.Remove(this.UsersTabPage);
                this.Add_Training.Enabled = this.Add_Job.Enabled = this.Add_Injury.Enabled =
                this.Add_Champioship.Enabled = false;
            }

            else if (this.CurrentUser.Type == "Manager")
            {
                this.Edit_User.Enabled = this.Edit_Training.Enabled = this.Edit_Job.Enabled = this.Edit_Injury.Enabled =
                this.Edit_Champioship.Enabled = false;
                this.Add_User.Enabled = this.Add_Training.Enabled = this.Add_Job.Enabled = this.Add_Injury.Enabled =
                this.Add_Champioship.Enabled = false; this.Show_User_History.Enabled = false;

            }
            else if (this.CurrentUser.Type == "Doctor")
            {
                this.Settings_Tab_Group.TabPages.Clear();
                this.Settings_Tab_Group.TabPages.Add(this.MeTabPage);
                this.Settings_Tab_Group.TabPages.Add(this.InjuriesTabPage);
            }
            else if (this.CurrentUser.Type == "Trainer")
            {
                this.Settings_Tab_Group.TabPages.Clear();
                this.Settings_Tab_Group.TabPages.Add(this.MeTabPage);
                this.Settings_Tab_Group.TabPages.Add(this.Training_type_Tab_Page);
            }
        }

        private void Show_User_History_Click(object sender, EventArgs e)
        {
            User_History UH = new User_History();
            UH.ShowDialog();
        }
    }
}