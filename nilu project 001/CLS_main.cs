using System;
using System.Data;
using System.Data.SqlClient;

namespace nilu_project_001
{
    class CLS_main
    {
        public static SqlConnection conn = new SqlConnection("data source =.;initial catalog=DOB_Shopping_management;user id=sa;password=admin@123;");
        public CLS_main()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();

            }
        }
        public static void Addusercontrol(DevExpress.XtraEditors.XtraUserControl uc, System.Windows.Forms.Panel place)
        {
            if (true)
            {
                place.Controls.Clear();
                uc.Dock = System.Windows.Forms.DockStyle.Fill;
                uc.BringToFront();
                place.Controls.Add(uc);
                place.BringToFront();
            }

            return;
        }

        public static bool RunSql(string command)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();

                }
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public static DataTable LoadData(string command)
        {
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            return dt;

        }
        public static string username = "";//for login saved username
        public static string password = "";//for login saved pasword
        public static string user_no= "";//for validating user and database entry for login user
        public static bool login = true;//make false to get in login panel first...
        public static string login_name = "user_login";//stores user name 
        
    }
}
