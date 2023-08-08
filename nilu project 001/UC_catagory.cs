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
    public partial class UC_catagory : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_catagory()
        {
            InitializeComponent();
        }

        private void UC_catagory_Load(object sender, EventArgs e)
        {
            try
            {
                if (CLS_main.conn.State == System.Data.ConnectionState.Closed)
                {
                    CLS_main.conn.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from catagory ", CLS_main.conn);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                cmb_catagory.DataSource = dt;
                cmb_catagory.DisplayMember = "name";
                cmb_catagory.ValueMember = "id";
                
                cmb_brand_catagory .DataSource = dt;
                cmb_brand_catagory.DisplayMember = "name";
                cmb_brand_catagory.ValueMember = "id";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (CLS_main.conn.State == System.Data.ConnectionState.Closed)
                {
                    CLS_main.conn.Open();
                }
                if (!string.IsNullOrEmpty (txt_catagory .Text ))
                {
                    SqlCommand cmd = new SqlCommand("insert into catagory values('"+txt_catagory .Text +"')",CLS_main .conn );
                    cmd.ExecuteNonQuery();
                    MessageBox .Show ("catagary Added Succesfully","catagory Added",MessageBoxButtons.OK,MessageBoxIcon.Information );
                    txt_catagory.Text = "";

                }
                else
                {
                    MessageBox.Show("Empty catagory name", "Invalid catagory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CLS_main.conn.State == System.Data.ConnectionState.Closed)
                {
                    CLS_main.conn.Open();
                }
                if (!string.IsNullOrEmpty((string)cmb_catagory .Text))
                {
                    SqlCommand cmd = new SqlCommand("delete from catagory where id ='" + cmb_catagory.SelectedValue + "'", CLS_main.conn);
                    cmd.ExecuteNonQuery ();
                    MessageBox.Show("Catagory remove Sucesfully", "Catagory Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UC_catagory c1 = new UC_catagory();
                    CLS_main.Addusercontrol(c1, panel2);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_brand_add_Click(object sender, EventArgs e)
        {

            try
            {
                if (CLS_main.conn.State == System.Data.ConnectionState.Closed)
                {
                    CLS_main.conn.Open();
                }
                if (!string.IsNullOrEmpty(cmb_brand_catagory .Text))
                {
                    SqlCommand cmd = new SqlCommand("insert into brand(name,cata_id) values('"+txt_brand.Text  +"','" + cmb_brand_catagory .SelectedValue + "')", CLS_main.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Brand Added Succesfully", "brand Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_brand.Text = "";

                }
                else
                {
                    MessageBox.Show("Empty Brand name", "Invalid Brand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void brn_brand_remove_Click(object sender, EventArgs e)
        {

            try
            {
                if (CLS_main.conn.State == System.Data.ConnectionState.Closed)
                {
                    CLS_main.conn.Open();
                }
                if (!string.IsNullOrEmpty((cmb_brand_catagory .SelectedValue).ToString ()))
                {
                    SqlCommand cmd = new SqlCommand("delete from brand where cata_id ='" + cmb_brand_catagory .SelectedValue + "' and id='"+cmb_brand .SelectedValue+"' ", CLS_main.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("brand remove Sucesfully", "brand Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UC_catagory c1 = new UC_catagory();
                    CLS_main.Addusercontrol(c1, panel2);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UC_catagory_Leave(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmb_brand_catagory_Leave(object sender, EventArgs e)
        {
            try
            {
                if (CLS_main.conn.State == System.Data.ConnectionState.Closed)
                {
                    CLS_main.conn.Open();
                }
                if (!string.IsNullOrEmpty((cmb_brand_catagory.SelectedValue).ToString()))
                {
                    SqlCommand cmd = new SqlCommand("select id,name from brand where cata_id='" + cmb_brand_catagory.SelectedValue + "'", CLS_main.conn);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    cmb_brand.DataSource = dt;
                    cmb_brand.DisplayMember = "name";
                    cmb_brand.ValueMember = "id";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
