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
    public partial class User_History : Form
    {
        public User_History()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_History_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void Refresh()
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Parameter", 15);
            DBManager D = new DBManager();
            this.History.DataSource = D.ExecuteReader(StoredProcedures.Show, Parameters);
            this.History.Refresh();
            Parameters.Clear();
        }

        private void Delete_Record_Click(object sender, EventArgs e)
        {
            if (this.History.SelectedRows.Count == 1)
            {
                Manipulate_Look_Up MLK = new Manipulate_Look_Up();
                string S = this.History.Rows[this.History.CurrentRow.Index].Cells[0].ToString();
                MLK.DeleteAction(S);
                this.Refresh();
                MessageBox.Show("Record Deleted");
            }
            else
                MessageBox.Show("Select ONE Record to Delete");
        }

        private void Delete_All_Click(object sender, EventArgs e)
        {
            Manipulate_Look_Up MLK = new Manipulate_Look_Up();
            MLK.DeleteAll();
            this.Refresh();
            MessageBox.Show("All Records Deleted");
        }
    }
}
