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
using System.IO;
using System.Diagnostics;

namespace Project
{
    public partial class Main_Menu : Form
    {
        User CurrentUser = new User();
        public Main_Menu(User CurrUsr)
        {
            InitializeComponent();
            CurrentUser = CurrUsr;
            this.WelcomeUser.Text = "Welcome " + CurrentUser.Name;
            this.Apply_Privileges();

        }

        private void Add_Player_Click(object sender, EventArgs e)
        {
            Add_Edit_Player Add_Player = new Add_Edit_Player(1 , CurrentUser);
            Add_Player.ShowDialog();
            this.Refresh();
        }

        private void Edit_Player_Click(object sender, EventArgs e)
        {
            if (this.Players_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Player Edit_Player = new Add_Edit_Player(2, CurrentUser);
                Edit_Player.SetDataBeforEdit(this.Players_List_View, this.Players_List_View.CurrentRow.Index);
                Edit_Player.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Player To Edit");
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Refresh()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Parameter", 1);
            DBManager D = new DBManager();
            this.Players_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Players_List_View.Refresh();



            Parameters.Clear();
            Parameters.Add("@Parameter", 2);
            this.Employee_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Injuries_List_View.Refresh();


            Parameters.Clear();
            Parameters.Add("@Parameter", 3);
            this.Match_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Match_List_View.Refresh();


            Parameters.Clear();
            Parameters.Add("@Parameter", 4);
            this.Training_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Training_List_View.Refresh();



            Parameters.Clear();
            Parameters.Add("@Parameter", 5);
            this.Champiosihps_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Champiosihps_List_View.Refresh();


            Parameters.Clear();
            Parameters.Add("@Parameter", 6);
            this.Injuries_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Injuries_List_View.Refresh();

            Parameters.Clear();
            Parameters.Add("@Parameter", 7);
            this.Contracts_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Contracts_List_View.Refresh();

            Parameters.Clear();
            Parameters.Add("@Parameter", 8);
            this.Sponsors_List_View.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.Sponsors_List_View.Refresh();


        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            Add_Edit_Employee AddEmployee = new Add_Edit_Employee(1, CurrentUser);
            AddEmployee.ShowDialog();
            this.Refresh();
        }

        private void Edit_Employee_Click(object sender, EventArgs e)
        {
            if (this.Employee_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Employee EditEmployee = new Add_Edit_Employee(2, CurrentUser);
                EditEmployee.SetDataBeforEdit(this.Employee_List_View, this.Employee_List_View.CurrentRow.Index);
                EditEmployee.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");
        }

        private void Add_Match_Click(object sender, EventArgs e)
        {
            Add_Edit_Match AddMatch = new Add_Edit_Match(1, CurrentUser);
            AddMatch.ShowDialog();
            this.Refresh();
        }

        private void Edit_Match_Click(object sender, EventArgs e)
        {
            if (this.Match_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Match EditMatch = new Add_Edit_Match(2, CurrentUser);
                EditMatch.SetDataBeforEdit(this.Match_List_View, this.Match_List_View.CurrentRow.Index);
                EditMatch.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");
        }

        private void Add_Training_Click(object sender, EventArgs e)
        {
            Add_Edit_Training AddTraining = new Add_Edit_Training(1, CurrentUser);
            AddTraining.ShowDialog();
            this.Refresh();
        }

        private void Edit_Training_Click(object sender, EventArgs e)
        {
            if (this.Training_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Training EditTrainig = new Add_Edit_Training(2 , CurrentUser);
                EditTrainig.SetDataBeforEdit(this.Training_List_View, this.Training_List_View.CurrentRow.Index);
                EditTrainig.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");
        }

        private void Add_Competition_Click(object sender, EventArgs e)
        {
            Add_Edit_Competition AddComp = new Add_Edit_Competition(1 ,  CurrentUser);
            AddComp.ShowDialog();
            this.Refresh();
        }

        private void Edit_Competition_Click(object sender, EventArgs e)
        {
            if (this.Champiosihps_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Competition EditComp = new Add_Edit_Competition(2 , CurrentUser);
                EditComp.SetDataBeforEdit(this.Champiosihps_List_View, this.Champiosihps_List_View.CurrentRow.Index);
                EditComp.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");
        }

        private void Add_Injury_Click(object sender, EventArgs e)
        {
            Add_Edit_Injuries AddInjury = new Add_Edit_Injuries(1 ,  CurrentUser);
            AddInjury.ShowDialog();
            this.Refresh();
        }

        private void Edit_Injury_Click(object sender, EventArgs e)
        {
            if (Injuries_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Injuries EditInjury = new Add_Edit_Injuries(2, CurrentUser);
                EditInjury.SetDataBeforeEdit(this.Injuries_List_View, this.Injuries_List_View.CurrentRow.Index);
                EditInjury.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");
        }

        private void Add_Contract_Click(object sender, EventArgs e)
        {
            Add_Edit_Contract AddContract = new Add_Edit_Contract(1, CurrentUser);
            AddContract.ShowDialog();
            this.Refresh();
        }

        private void Edit_Contract_Click(object sender, EventArgs e)
        {
            if (this.Contracts_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Contract EditContract = new Add_Edit_Contract(2, CurrentUser);
                EditContract.SetDataBeforeEdit(this.Contracts_List_View, this.Contracts_List_View.CurrentRow.Index);
                EditContract.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");
        }

        private void Add_Sponsor_Click(object sender, EventArgs e)
        {
            Add_Edit_Sponsor AddSponsor = new Add_Edit_Sponsor(1, CurrentUser);
            AddSponsor.ShowDialog();
            this.Refresh();
        }

        private void Edit_Sponsor_Click(object sender, EventArgs e)
        {
            if (this.Sponsors_List_View.SelectedRows.Count == 1)
            {
                Add_Edit_Sponsor EditSponsor = new Add_Edit_Sponsor(2, CurrentUser);
                EditSponsor.SetDataBeforeEdit(this.Sponsors_List_View, this.Sponsors_List_View.CurrentRow.Index);
                EditSponsor.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Edit");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (DResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this.CurrentUser , this);
            settings.ShowDialog();
        }

        private void EditPerformance_Click(object sender, EventArgs e)
        {

        }

        private void ShowPerformance_Click(object sender, EventArgs e)
        {
            Player_Performance_Menu PerMen = new Player_Performance_Menu();
            PerMen.ShowDialog();
        }

        private void Set_Absence_Click(object sender, EventArgs e)
        {
            Add_Edit_Absent_Players AddAbsent = new Add_Edit_Absent_Players();
            AddAbsent.ShowDialog();
        }


        private void Apply_Privileges()
        {
            if(this.CurrentUser.Type == "Add Employee")
            {
                this.Edit_Player.Enabled = this.Edit_Employee.Enabled = this.Edit_Match.Enabled = this.Edit_Training.Enabled =
                this.ShowPerformance.Enabled = this.Set_Absence.Enabled = this.Edit_Competition.Enabled =
                this.Edit_Injury.Enabled = this.Edit_Contract.Enabled = this.Edit_Sponsor.Enabled = false;
            }

            else if(this.CurrentUser.Type == "Edit Employee")
            {
                this.Add_Player.Enabled = this.Add_Employee.Enabled = this.Add_Match.Enabled = this.Add_Training.Enabled =
                this.ShowPerformance.Enabled = this.Set_Absence.Enabled = this.Add_Competition.Enabled =
                this.Add_Injury.Enabled = this.Add_Contract.Enabled = this.Add_Sponsor.Enabled = false;
            }

            else if(this.CurrentUser.Type == "Manager")
            {
                this.Edit_Player.Enabled = this.Edit_Employee.Enabled = this.Edit_Match.Enabled = this.Edit_Training.Enabled =
                this.ShowPerformance.Enabled = this.Set_Absence.Enabled = this.Edit_Competition.Enabled =
                this.Edit_Injury.Enabled = this.Edit_Contract.Enabled = this.Edit_Sponsor.Enabled = false;
  
                this.Add_Player.Enabled = this.Add_Employee.Enabled = this.Add_Match.Enabled = this.Add_Training.Enabled =
                this.Add_Competition.Enabled =
                this.Add_Injury.Enabled = this.Add_Contract.Enabled = this.Add_Sponsor.Enabled = false;

            }
            else if(this.CurrentUser.Type == "Doctor")
            {
                this.Main_Menu_Tab.TabPages.Clear();
                this.Main_Menu_Tab.TabPages.Add(this.Player_Tab_Page);
                this.Main_Menu_Tab.TabPages.Add(this.Injuries_Tab_Page);
                this.Edit_Player.Hide();
                this.Add_Player.Hide();
                this.ShowPerformance.Hide();
            }
            else if(this.CurrentUser.Type == "Trainer")
            {
                this.Main_Menu_Tab.TabPages.Clear();
                this.Main_Menu_Tab.TabPages.Add(this.Player_Tab_Page);
                this.Main_Menu_Tab.TabPages.Add(this.Trainig_Tab_Page);
                this.Edit_Player.Enabled = false;
                this.Add_Player.Enabled = false;
            }
        }

    }

}
