using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nilu_project_001
{
    public partial class UC_Login : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }
        SqlDataReader drd;

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txt_password.Text) && !string.IsNullOrWhiteSpace(txt_username.Text))
                {
                    if (CLS_main.conn.State == ConnectionState.Closed)
                    {
                        CLS_main.conn.Open();

                    }
                    SqlCommand cmd = new SqlCommand("select username,id from login where username='" + txt_username.Text + "' and pass='" + txt_password.Text + "'", CLS_main.conn);
                    drd = cmd.ExecuteReader();
                    if (drd.Read())
                    {
                        CLS_main.login_name = drd["username"].ToString();
                        CLS_main.user_no = drd["id"].ToString();
                        drd.Close();
                        CLS_main.login = true;
                        txt_password.Text = "";
                        txt_username.Text = "";
                        MessageBox.Show("login Succesfully For User Name : " + CLS_main.login_name + "");
                        UC_Home h1 = new UC_Home();
                        CLS_main.Addusercontrol(h1, panel1);
                    }
                    else
                    {
                        CLS_main.login_name = "User login";
                        CLS_main.user_no = "";
                        CLS_main.login = false;
                        drd.Close();
                        txt_password.Text = "";
                        txt_username.Text = "";
                        MessageBox.Show("Sorry User not found : " + txt_username.Text + " or Invalid password");
                    }

                }
                else
                {
                    MessageBox.Show("Enter Valid User Id And Password To Login", "Empty Statements");
                    txt_username.Focus();
                    txt_password.Text = "";
                }
            }
            catch (Exception ex)
            {
                CLS_main.login_name = "User login";
                CLS_main.login = false;
                CLS_main.user_no = "";
                txt_password.Text = "";
                txt_username.Text = "";
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_NewAdmin n1 = new UC_NewAdmin();
            CLS_main.Addusercontrol(n1, panel1);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_password.Text) && !string.IsNullOrEmpty(txt_username.Text))
                {
                    if (CLS_main.conn.State == ConnectionState.Closed)
                    {
                        CLS_main.conn.Open();

                    }

                    bool grant = false;
                    SqlCommand cmd1 = new SqlCommand("select username from login where username='" + txt_username.Text + "' and pass ='" + txt_password.Text + "'", CLS_main.conn);
                    drd = cmd1.ExecuteReader();
                    if (drd.Read())
                    {
                        drd.Close();
                        grant = true;
                    }
                    else
                    {
                        drd.Close();

                    }
                    if (grant)
                    {
                        DialogResult da = MessageBox.Show("Conform you wa to remove Admin", "Conformation ", MessageBoxButtons.OKCancel);

                        if (da == DialogResult.OK)
                        {
                            SqlCommand cmd = new SqlCommand("delete from login where username='" + txt_username.Text + "' and pass ='" + txt_password.Text + "'", CLS_main.conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Admin removed succesfully", "Removed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            txt_username.Text = "";
                            txt_password.Text = "";
                        }


                    }
                    else
                    {
                        txt_username.Text = "";
                        txt_password.Text = "";
                        MessageBox.Show("Usernot found", "Invalid   Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("enter Username and password first ");
                    txt_username.Focus();
                    txt_password.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_ForgetPassword f1 = new UC_ForgetPassword();
            CLS_main.Addusercontrol(f1, panel1);
        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_password.Text = CLS_main.password;
            txt_username.Text = CLS_main.username;
            txt_username.Focus();
        }
    }
}
