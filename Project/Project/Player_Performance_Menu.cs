using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Player_Performance_Menu : Form
    {
        public Player_Performance_Menu()
        {
            InitializeComponent();
            this.Refresh();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_Edit_Performance AddPerformance = new Add_Edit_Performance(1);
            AddPerformance.ShowDialog();
            this.Refresh();
        }

        private void Refresh()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Parameter", 14);
            DBManager D = new DBManager();
            this.PerformanceListView.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.PerformanceListView.Refresh();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (this.PerformanceListView.SelectedRows.Count == 1)
            {
                Add_Edit_Performance EditPerformance = new Add_Edit_Performance(2);
                EditPerformance.SetDataBeforEdit(this.PerformanceListView, this.PerformanceListView.CurrentRow.Index);
                EditPerformance.ShowDialog();
                this.Refresh();
            }
            else
                MessageBox.Show("Select ONE Record To Add");
        }
    }
}
