using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nilu_project_001
{
    public partial class UC_ForgetPassword : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_ForgetPassword()
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
                    bool grant = false;
                    SqlCommand cmd1 = new SqlCommand("select seckey,dob from login where username='" + txt_username.Text + "'", CLS_main.conn);
                    SqlDataReader drd = cmd1.ExecuteReader();
                    if (drd.Read())
                    {
                        string secquestion = drd["seckey"].ToString();
                        string dob = drd["dob"].ToString();
                        grant = (secquestion == txt_secutitypinn.Text && dob == txt_dob.Text) ? true : false;
                    }
                    else
                    {
                        drd.Close();
                        MessageBox.Show("User Not Found", "Invalid user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Text = "";
                    }
                    if (grant)
                    {
                        CLS_main.username = txt_username.Text;
                        CLS_main.password = txt_password.Text;

                        SqlCommand cmd = new SqlCommand("update login set pass='" + txt_password.Text + "' where username='" + txt_username.Text + "'", CLS_main.conn);
                        cmd.ExecuteNonQuery();
                        DialogResult dr = MessageBox.Show("Admin password updated Safly\nYou Can Login Now", "Admin Password Updated", MessageBoxButtons.OK);
                        if (dr == DialogResult.OK)
                        {
                            UC_Login l1 = new UC_Login();
                            CLS_main.Addusercontrol(l1, panel1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalid securitypin and date of birth", "Wrong Detail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UC_ForgetPassword_Load(object sender, EventArgs e)
        {
            txt_username.Text = CLS_main.username;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Login loin = new UC_Login();
            CLS_main.Addusercontrol(loin, panel1);
        }
    }
}
