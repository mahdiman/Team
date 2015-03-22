using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Project
{
    public class Manipulate_Look_Up
    {
        DBManager Manager = new DBManager();
        public void DeleteAction(string ID)
        {
            string S = "DELETE FROM Admin_Lookup WHERE ID='"+ID+"';";
            
            SqlCommand CMD = new SqlCommand(S, Manager.myConnection);
            CMD.ExecuteNonQuery();
        }


        public void DeleteAll()
        {
            string S = "DELETE FROM Admin_Lookup;";

            SqlCommand CMD = new SqlCommand(S, Manager.myConnection);
            CMD.ExecuteNonQuery();
        }

        public void InsertData(string UserName , string Activity)
        {
            string Date_ = System.DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            string S = "INSERT INTO Admin_Lookup (UserName , Activity , ACt_Date) VALUES ('" + UserName + "','" + Activity + "','" +
                Date_.ToString() + "');";

            SqlCommand CMD = new SqlCommand(S, Manager.myConnection);
            CMD.ExecuteNonQuery();
        }
    }
}
