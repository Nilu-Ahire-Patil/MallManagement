using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace nilu_project_001
{
    public partial class UC_Customer : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_Customer()
        {
            InitializeComponent();
        }
        private bool CheckFields()
        {
            if (String .IsNullOrWhiteSpace (txt_Fnme .Text ))
            {
                MessageBox .Show ("Enter First Name","Empty Field",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                txt_Fnme.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txt_contact .Text))
            {
                MessageBox.Show("Enter Contact", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contact.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txt_gmail .Text))
            {
                MessageBox.Show("Enter Gmail", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_gmail.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txt_state.Text))
            {
                MessageBox.Show("Enter State", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_state.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txt_DOB .Text))
            {
                MessageBox.Show("Enter Date Of Birth", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DOB .Focus();
            }
            else if (String.IsNullOrWhiteSpace(txt_current_add.Text))
            {
                MessageBox.Show("Enter Address", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_current_add.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txt_par_add .Text))
            {
                MessageBox.Show("Enter parmanent address", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_par_add .Focus();
            }
            else if (String.IsNullOrWhiteSpace(txt_gst_no .Text))
            {
                MessageBox.Show("Enter GST NO", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_gst_no .Focus();
            }
            else if (String.IsNullOrWhiteSpace(txt_invoice_no .Text))
            {
                MessageBox.Show("Enter Invoice No", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_invoice_no .Focus();
            }
            else
            {
                return true;
            }
            return false;
        }
        private void btn_more_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFields())
                {
                    string name = txt_Fnme.Text + " " + txt_Mname.Text + " " + txt_Sname.Text + " ";
                    DGV_Customer.Rows.Add(name, txt_DOB.Text, txt_contact.Text, txt_gmail.Text, txt_state.SelectedValue, txt_current_add.Text, txt_par_add.Text, txt_gst_no.Text, txt_invoice_no.Text,CLS_main .user_no);
                    CleareFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public static void LoadState(ComboBox txt_state)
        {
            try
            {
                txt_state.DataSource = CLS_main.LoadData("Select * from state");
                txt_state.DisplayMember = "name";
                txt_state.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void UC_Customer_Load(object sender, EventArgs e)
        {
            LoadState(txt_state);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Customer.CurrentCell.RowIndex!=-1)
                {
                    DGV_Customer.Rows.RemoveAt(DGV_Customer.CurrentCell.RowIndex);
                }
            }
            catch 
            {
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Customer .RowCount > 1)
                {
                    while ( 1< DGV_Customer .RowCount )
                    {
                        if (CLS_main .conn .State ==ConnectionState.Closed )
                        {
                            CLS_main .conn .Open ();
                        }
                        SqlCommand cmd = new SqlCommand("insert into customer (name,contact,gmail,dob,cur_add,per_add,state_id,gst_no,invoice_no,user_id)values (@name,@contact,@gmail,@dob,@cur_add,@per_add,@state_id,@gst_no,@invoice_no,@user_id)", CLS_main.conn);
                        cmd.Parameters .AddWithValue ("@name",DGV_Customer .Rows [0].Cells [0].Value . ToString());
                        cmd.Parameters .AddWithValue ("@dob",DGV_Customer .Rows [0].Cells [1].Value . ToString());
                        cmd.Parameters .AddWithValue ("@contact",DGV_Customer .Rows [0].Cells [2].Value . ToString());
                        cmd.Parameters .AddWithValue ("@gmail",DGV_Customer .Rows [0].Cells [3].Value . ToString());
                        cmd.Parameters .AddWithValue ("@state_id",DGV_Customer .Rows [0].Cells [4].Value . ToString());
                        cmd.Parameters .AddWithValue ("@cur_add",DGV_Customer .Rows [0].Cells [5].Value . ToString());
                        cmd.Parameters .AddWithValue ("@per_add",DGV_Customer .Rows [0].Cells [6].Value . ToString());
                        cmd.Parameters .AddWithValue ("@gst_no",DGV_Customer .Rows [0].Cells [7].Value . ToString());
                        cmd.Parameters .AddWithValue ("@invoice_no",DGV_Customer .Rows [0].Cells [8].Value . ToString());
                        cmd.Parameters .AddWithValue ("@user_id",DGV_Customer .Rows [0].Cells [9].Value . ToString());
                        cmd.ExecuteNonQuery();
                        DGV_Customer.Rows.RemoveAt(0);
                    }
                }
                CleareFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void clk_same_address_CheckedChanged(object sender, EventArgs e)
        {
            txt_par_add.Text = clk_same_address.Checked ? txt_current_add.Text : "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFields())
                {
                    if (DGV_Customer.CurrentCell.RowIndex != -1)
                    {
                        DGV_Customer.Rows.RemoveAt(DGV_Customer.CurrentCell.RowIndex);
                    }
                    string name = txt_Fnme.Text + " " + txt_Mname.Text + " " + txt_Sname.Text + " ";
                    DGV_Customer.Rows.Add(name, txt_DOB.Text, txt_contact.Text, txt_gmail.Text, txt_state.SelectedValue, txt_current_add.Text, txt_par_add.Text, txt_gst_no.Text, txt_invoice_no.Text, CLS_main.user_no);
                    CleareFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void DGV_Customer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Customer .SelectedRows.Count  !=-1)
                {
                    txt_Mname.Text = txt_Sname.Text = "";
                    txt_Fnme.Text = DGV_Customer.SelectedRows[0].Cells[0].Value.ToString();
                    txt_DOB.Text = DGV_Customer.SelectedRows[0].Cells[1].Value.ToString();
                    txt_contact.Text = DGV_Customer.SelectedRows[0].Cells[2].Value.ToString();
                    txt_gmail.Text = DGV_Customer.SelectedRows[0].Cells[3].Value.ToString();
                    txt_state.SelectedValue = DGV_Customer.SelectedRows[0].Cells[4].Value.ToString();
                    txt_current_add.Text = DGV_Customer.SelectedRows[0].Cells[5].Value.ToString();
                    txt_par_add.Text = DGV_Customer.SelectedRows[0].Cells[6].Value.ToString();
                    txt_gst_no.Text = DGV_Customer.SelectedRows[0].Cells[7].Value.ToString();
                    txt_invoice_no.Text = DGV_Customer.SelectedRows[0].Cells[8].Value.ToString();
                }
                
                // DGV_Customer.Rows.Remove(DGV_Customer.SelectedRows[0]);

            }
            catch (Exception ex)
            {
                
            }
        }
        private void CleareFields()
        {
            txt_Mname.Text = txt_Sname.Text = "";
            txt_Fnme.Text = "";
            txt_DOB.Text = "";
            txt_contact.Text = "";
            txt_gmail.Text = "";
            txt_state.Text  = "";
            txt_current_add.Text = "";
            txt_par_add.Text = "";
            txt_gst_no.Text = "";
            txt_invoice_no.Text = "";
        }
    }
}
