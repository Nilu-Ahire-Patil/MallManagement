using System;
using System.Windows.Forms;

namespace nilu_project_001
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void allbuttoncolourreset()
        {
            this.btn_sell.BackColor = System.Drawing.Color.MistyRose;
            this.btn_customer.BackColor = System.Drawing.Color.MistyRose;
            this.btn_product.BackColor = System.Drawing.Color.MistyRose;
            this.btn_employee.BackColor = System.Drawing.Color.MistyRose;
            this.btn_stock.BackColor = System.Drawing.Color.MistyRose;
            this.btn_suplier.BackColor = System.Drawing.Color.MistyRose;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            allbuttoncolourreset();
            if (loginfunction(panel_home))
            {
               
                this.btn_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))); 
       

                UC_Customer p1 = new UC_Customer();
                CLS_main.Addusercontrol(p1, panel_home);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            allbuttoncolourreset();
            if (loginfunction(panel_home))
            {
                this.btn_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));

                UC_Product p1 = new UC_Product();
                CLS_main.Addusercontrol(p1, panel_home);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            allbuttoncolourreset();
            if (loginfunction(panel_home))
            {
                
                this.btn_employee.BackColor = System.Drawing.Color.Azure;
                UC_Employee p1 = new UC_Employee();
                CLS_main.Addusercontrol(p1, panel_home);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            allbuttoncolourreset();
            if (loginfunction(panel_home))
            {
               
                this.btn_stock .BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

                UC_purches p1 = new UC_purches();
                CLS_main.Addusercontrol(p1, panel_home);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_Home p1 = new UC_Home();
            CLS_main.Addusercontrol(p1, panel_home);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You Want To Exit \n Press ok to conform", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allbuttoncolourreset();

            UC_Home p1 = new UC_Home();
            CLS_main.Addusercontrol(p1, panel_home);
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            allbuttoncolourreset();
            if (loginfunction(panel_home))
            {
                this.btn_suplier .BackColor = System.Drawing.Color.LavenderBlush;
                UC_Suplier P1 = new UC_Suplier();
                CLS_main.Addusercontrol(P1, panel_home);
            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {

            if (CLS_main.login_name == "user_login")
            {
                UC_Login l1 = new UC_Login();
                CLS_main.Addusercontrol(l1, panel_home);
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
        public static bool loginfunction(Panel place)
        {

            try
            {
                if (CLS_main.login)
                {
                    return true;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("You Have To login First\n Press ok to Go Login panel", "Login Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {

                        if (CLS_main.login_name == "user_login")
                        {
                            UC_Login l1 = new UC_Login();
                            CLS_main.Addusercontrol(l1, place);

                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("You allredy login ... \nWith user " + CLS_main.login_name + "\n Tap on ok to Logout", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.OK)
                            {
                                CLS_main.login = false;
                                CLS_main.login_name = "user_login";
                                UC_Home h1 = new UC_Home();
                                CLS_main.Addusercontrol(h1, place);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return false;
        }
        public static bool ValidateUser(string authuser)
        {
            if (authuser == CLS_main.login_name)
            {
                return true;
            }
            else
            {
                MessageBox.Show("You Are Not Valid User To Make This Opration \nGet Back With Valid User\nUser ID:" + authuser, "Opration Terminated[Invalid User]", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            return false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CLS_main.login)
            {
                DialogResult dr = MessageBox.Show("Conform To Logout", "Logout Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    CLS_main.login = false;
                    CLS_main.user_no = "";
                    CLS_main.login_name = "user_login";
                    DialogResult DR = MessageBox.Show("Logout Succesfully\n", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (DR == DialogResult.OK)
                    {
                        UC_Home h1 = new UC_Home();
                        CLS_main.Addusercontrol(h1, panel_home);
                    }
                }
            }
            else
            {
                loginfunction(panel_home);
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txt_username.Text = CLS_main.login_name;
        }
       // string selectbtn;
        private void btn_shopping_Click(object sender, EventArgs e)
        {
            allbuttoncolourreset();

            if (loginfunction(panel_home))
            {
               // selectbtn = "btn1";
                btn_sell.BackColor = System.Drawing.Color.Ivory;
                UC_Shopping   S1 = new UC_Shopping  ();
                CLS_main.Addusercontrol(S1, panel_home);
            }

        }

       
    }
}
