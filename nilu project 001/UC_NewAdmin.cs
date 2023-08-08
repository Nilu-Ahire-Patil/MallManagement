using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nilu_project_001
{
    public partial class UC_NewAdmin : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_NewAdmin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_username.Text))
                {
                    MessageBox.Show("Enter Username First");
                    txt_username.Focus();
                }
                else if (string.IsNullOrEmpty(txt_password.Text))
                {
                    MessageBox.Show("Enter Password First");
                    txt_password.Focus();
                }
                else if (string.IsNullOrEmpty(txt_secutitypinn.Text))
                {
                    MessageBox.Show("Enter Securtty pin First");
                    txt_secutitypinn.Focus();
                }
                else if (string.IsNullOrEmpty(txt_dob.Text))
                {
                    MessageBox.Show("Enter Date of Birth First");
                    txt_dob.Focus();
                }
                else
                {
                    if (CLS_main.conn.State == ConnectionState.Closed)
                    {
                        CLS_main.conn.Open();

                    }
                    SqlCommand cmd = new SqlCommand("insert into login (username,pass,seckey,dob) values ('" + txt_username.Text + "','" + txt_password.Text + "','" + txt_secutitypinn.Text + "','" + txt_dob.Text + "')", CLS_main.conn);
                    cmd.ExecuteNonQuery();
                    DialogResult dr = MessageBox.Show("Admin Added Safly\nYou Can Login Now", "Admin Added", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        CLS_main.username = txt_username.Text;
                        CLS_main.password = txt_password.Text;
                        UC_Login l1 = new UC_Login();
                        CLS_main.Addusercontrol(l1, panel1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (CLS_main.login_name == "user_login")
            {
                UC_Login l1 = new UC_Login();
                CLS_main.Addusercontrol(l1, panel1);
            }
            else
            {
                DialogResult result = MessageBox.Show("You allredy login ... \nWith user " + CLS_main.login_name + "\n Tap on ok to Logout", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    CLS_main.login = false;
                    CLS_main.login_name = "user_login";
                }
            }
        }
    }
}
