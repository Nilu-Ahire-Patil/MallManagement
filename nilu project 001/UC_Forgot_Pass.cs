using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilu_project_001
{
    public partial class UC_Forgot_Pass : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_Forgot_Pass()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_login f1 = new UC_login();
            CLS_main.Addusercontrol(f1,panel1);
        }
        SqlDataReader drd;
        private void btn_AddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (CLS_main.conn.State == System.Data.ConnectionState.Closed)
                {
                    CLS_main.conn.Open();
                }
                if ((!string.IsNullOrEmpty(pass.Text)) && (!string.IsNullOrEmpty(pass.Text)) && (!string.IsNullOrEmpty(txt_seckey.Text)) && (!string.IsNullOrEmpty(txt_username.Text))) 
                {
                    SqlCommand cmd = new SqlCommand("select * from login where username='" + txt_username.Text + "' and seckey='" + txt_seckey.Text + "' and dob='" + txt_dob .Text +"'", CLS_main.conn);
                    drd = cmd.ExecuteReader();
                    if (drd.Read())
                    {
                        drd.Close();
                        SqlCommand cmd2 = new SqlCommand("update login set pass='" + pass.Text + "'where username='" + txt_username.Text + "' and seckey='" + txt_seckey.Text + "' and dob='" + txt_dob .Text + "'", CLS_main.conn);
                        DialogResult dr = MessageBox.Show("Password Updated Succesfully\n press ok to login", "password Updated", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                        {
                            UC_NewAdmin.username = txt_username.Text;
                            UC_NewAdmin.password = pass.Text;
                            UC_login  f1 = new UC_login ();
                            CLS_main.Addusercontrol(f1, panel1);
                        }
                    }
                    else
                    {
                        drd.Close();
                        MessageBox.Show("You Enter Wrong Detail \nUser Not Found\n Plz Check your detail  ", "Error");
                    }

                }
                else
                {
                    MessageBox.Show("Empty Fields");
                }

            }
            catch (Exception ex)
            {
                drd.Close();
                MessageBox .Show(ex.Message);
                
            }
        }
    }
}
