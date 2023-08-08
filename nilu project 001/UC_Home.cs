using System;
using System.Drawing;

namespace nilu_project_001
{
    public partial class UC_Home : DevExpress.XtraEditors.XtraUserControl
    {
        int x = 1, y = 262;
        public UC_Home()
        {
            InitializeComponent();
            // timer1.Start();
        }

        private void btn_cust_save1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.SetBounds(x, y, 1, 1);
            label2.SetBounds(x + 100, y + 100, 1, 1);
            x += 5;
            y += 5;
            if (x >= 934)
            {
                x = 1;
            }
            if (y >= 668)
            {
                y = 1;
            }
            label3.ForeColor = label3.ForeColor == Color.Red ? Color.White : Color.Red;

        }
    }
}
