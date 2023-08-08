using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nilu_project_001
{
    public partial class UC_Product : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_Product()
        {
            InitializeComponent();
        }

        private void UC_Product_Load(object sender, System.EventArgs e)
        {
            try
            {
                if (CLS_main .conn .State ==System.Data.ConnectionState.Closed )
                {
                    CLS_main.conn.Open();
                }
                SqlCommand cmd=new SqlCommand ("select * from catagory ",CLS_main .conn );   
                SqlDataAdapter adpt = new SqlDataAdapter(cmd );
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                cmb_catagory.DataSource = dt;
                cmb_catagory.DisplayMember = "name";
                cmb_catagory.ValueMember = "id";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void cmb_catagory_Leave(object sender, System.EventArgs e)
        {
            try
            {
                if (!string .IsNullOrEmpty ((string)cmb_catagory .Text ))
                {
                    if (CLS_main .conn .State ==System.Data.ConnectionState.Closed )
                    {
                        CLS_main.conn.Open();

                    }
                    SqlCommand cnd = new SqlCommand("select id,name from brand where cata_id='" + cmb_catagory.SelectedValue  + "'", CLS_main.conn);
                    SqlDataAdapter adpt=new SqlDataAdapter  (cnd);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    cmb_brand.DataSource = dt;
                    cmb_brand.ValueMember = "id";
                    cmb_brand .DisplayMember ="name";   
                }
                else
                {
                  DialogResult dr=  MessageBox .Show ("Enter valid catagory\n If You Want To Add Ctagory Press yes","Invalid Catagory",MessageBoxButtons.YesNoCancel ,MessageBoxIcon.Error );
                    if (dr==DialogResult.Yes)
                    { 
                        UC_catagory c1 = new UC_catagory();
                        CLS_main.Addusercontrol(c1, panel2);
                    }
                   //cmb_catagory.Focus();
                }

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        private void cmb_brand_Leave(object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty (cmb_brand .DisplayMember ))
                {
                    if (CLS_main .conn .State ==System.Data.ConnectionState.Closed )
                    {
                        CLS_main .conn.Open();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Enter Valid Brand Name", "Invalid Brand Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // cmb_brand.Focus();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        private void btn_more_Click(object sender, System.EventArgs e)
        {

        }
    }
}
