
namespace nilu_project_001
{
    partial class UC_Product
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Product));
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_brand = new System.Windows.Forms.ComboBox();
            this.cmb_catagory = new System.Windows.Forms.ComboBox();
            this.txt_selling_price = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_purches_price = new DevExpress.XtraEditors.TextEdit();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_date_of_exp = new DevExpress.XtraEditors.DateEdit();
            this.txt_date_of_importing = new DevExpress.XtraEditors.DateEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_pro_name = new DevExpress.XtraEditors.TextEdit();
            this.panel_customer_home = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_show = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_more = new DevExpress.XtraEditors.SimpleButton();
            this.btn_remove = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_selling_price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_purches_price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date_of_exp.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date_of_exp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date_of_importing.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date_of_importing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pro_name.Properties)).BeginInit();
            this.panel_customer_home.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupbox.Controls.Add(this.panel2);
            this.groupbox.Controls.Add(this.cmb_brand);
            this.groupbox.Controls.Add(this.cmb_catagory);
            this.groupbox.Controls.Add(this.txt_selling_price);
            this.groupbox.Controls.Add(this.label17);
            this.groupbox.Controls.Add(this.txt_purches_price);
            this.groupbox.Controls.Add(this.label23);
            this.groupbox.Controls.Add(this.txt_date_of_exp);
            this.groupbox.Controls.Add(this.txt_date_of_importing);
            this.groupbox.Controls.Add(this.label15);
            this.groupbox.Controls.Add(this.label19);
            this.groupbox.Controls.Add(this.label20);
            this.groupbox.Controls.Add(this.label21);
            this.groupbox.Controls.Add(this.label22);
            this.groupbox.Controls.Add(this.txt_pro_name);
            this.groupbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupbox.Location = new System.Drawing.Point(0, 0);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(934, 273);
            this.groupbox.TabIndex = 1;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Product Deail";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(516, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 247);
            this.panel2.TabIndex = 32;
            // 
            // cmb_brand
            // 
            this.cmb_brand.FormattingEnabled = true;
            this.cmb_brand.Location = new System.Drawing.Point(389, 48);
            this.cmb_brand.Name = "cmb_brand";
            this.cmb_brand.Size = new System.Drawing.Size(121, 21);
            this.cmb_brand.TabIndex = 31;
            this.cmb_brand.Leave += new System.EventHandler(this.cmb_brand_Leave);
            // 
            // cmb_catagory
            // 
            this.cmb_catagory.FormattingEnabled = true;
            this.cmb_catagory.Location = new System.Drawing.Point(160, 48);
            this.cmb_catagory.Name = "cmb_catagory";
            this.cmb_catagory.Size = new System.Drawing.Size(121, 21);
            this.cmb_catagory.TabIndex = 30;
            this.cmb_catagory.Leave += new System.EventHandler(this.cmb_catagory_Leave);
            // 
            // txt_selling_price
            // 
            this.txt_selling_price.Location = new System.Drawing.Point(389, 167);
            this.txt_selling_price.Name = "txt_selling_price";
            this.txt_selling_price.Size = new System.Drawing.Size(121, 20);
            this.txt_selling_price.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(299, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 28;
            this.label17.Text = "Selling Price";
            // 
            // txt_purches_price
            // 
            this.txt_purches_price.Location = new System.Drawing.Point(161, 167);
            this.txt_purches_price.Name = "txt_purches_price";
            this.txt_purches_price.Size = new System.Drawing.Size(108, 20);
            this.txt_purches_price.TabIndex = 27;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(55, 169);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 16);
            this.label23.TabIndex = 26;
            this.label23.Text = "Purches Price";
            // 
            // txt_date_of_exp
            // 
            this.txt_date_of_exp.EditValue = null;
            this.txt_date_of_exp.Location = new System.Drawing.Point(160, 131);
            this.txt_date_of_exp.Name = "txt_date_of_exp";
            this.txt_date_of_exp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_date_of_exp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_date_of_exp.Size = new System.Drawing.Size(295, 20);
            this.txt_date_of_exp.TabIndex = 25;
            // 
            // txt_date_of_importing
            // 
            this.txt_date_of_importing.EditValue = null;
            this.txt_date_of_importing.Location = new System.Drawing.Point(284, 214);
            this.txt_date_of_importing.Name = "txt_date_of_importing";
            this.txt_date_of_importing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_date_of_importing.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_date_of_importing.Size = new System.Drawing.Size(226, 20);
            this.txt_date_of_importing.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(55, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Date Of Expairy";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(148, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "Date Of Importing";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(309, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "Brand";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(55, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Catagory";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(55, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Product Name";
            // 
            // txt_pro_name
            // 
            this.txt_pro_name.Location = new System.Drawing.Point(160, 88);
            this.txt_pro_name.Name = "txt_pro_name";
            this.txt_pro_name.Size = new System.Drawing.Size(294, 20);
            this.txt_pro_name.TabIndex = 1;
            // 
            // panel_customer_home
            // 
            this.panel_customer_home.Controls.Add(this.btn_search);
            this.panel_customer_home.Controls.Add(this.btn_show);
            this.panel_customer_home.Controls.Add(this.btn_update);
            this.panel_customer_home.Controls.Add(this.btn_more);
            this.panel_customer_home.Controls.Add(this.btn_remove);
            this.panel_customer_home.Controls.Add(this.panel1);
            this.panel_customer_home.Controls.Add(this.groupbox);
            this.panel_customer_home.Location = new System.Drawing.Point(0, 1);
            this.panel_customer_home.Name = "panel_customer_home";
            this.panel_customer_home.Size = new System.Drawing.Size(934, 668);
            this.panel_customer_home.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_search.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_search.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_search.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_search.Appearance.Options.UseBackColor = true;
            this.btn_search.Appearance.Options.UseBorderColor = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_search.Location = new System.Drawing.Point(746, 287);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(185, 38);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "Search";
            // 
            // btn_show
            // 
            this.btn_show.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_show.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_show.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_show.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_show.Appearance.Options.UseBackColor = true;
            this.btn_show.Appearance.Options.UseBorderColor = true;
            this.btn_show.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_show.ImageOptions.SvgImage = global::nilu_project_001.Properties.Resources.trackingchanges_showmarkup;
            this.btn_show.Location = new System.Drawing.Point(560, 287);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(185, 38);
            this.btn_show.TabIndex = 17;
            this.btn_show.Text = "Show";
            // 
            // btn_update
            // 
            this.btn_update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_update.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_update.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_update.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_update.Appearance.Options.UseBackColor = true;
            this.btn_update.Appearance.Options.UseBorderColor = true;
            this.btn_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_update.ImageOptions.SvgImage = global::nilu_project_001.Properties.Resources.updatetableofcontents;
            this.btn_update.Location = new System.Drawing.Point(374, 287);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(185, 38);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update";
            // 
            // btn_more
            // 
            this.btn_more.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_more.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_more.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_more.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_more.Appearance.Options.UseBackColor = true;
            this.btn_more.Appearance.Options.UseBorderColor = true;
            this.btn_more.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_more.ImageOptions.SvgImage = global::nilu_project_001.Properties.Resources.neworder;
            this.btn_more.Location = new System.Drawing.Point(188, 287);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(185, 38);
            this.btn_more.TabIndex = 15;
            this.btn_more.Text = "Save";
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_remove.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_remove.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_remove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_remove.Appearance.Options.UseBackColor = true;
            this.btn_remove.Appearance.Options.UseBorderColor = true;
            this.btn_remove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_remove.ImageOptions.SvgImage = global::nilu_project_001.Properties.Resources.removefooter1;
            this.btn_remove.Location = new System.Drawing.Point(2, 287);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(185, 38);
            this.btn_remove.TabIndex = 14;
            this.btn_remove.Text = "Remove";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 337);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(934, 337);
            this.dataGridView2.TabIndex = 2;
            // 
            // UC_Product
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_customer_home);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(934, 668);
            this.Load += new System.EventHandler(this.UC_Product_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_selling_price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_purches_price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date_of_exp.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date_of_exp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date_of_importing.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date_of_importing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pro_name.Properties)).EndInit();
            this.panel_customer_home.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_selling_price;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.TextEdit txt_purches_price;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraEditors.DateEdit txt_date_of_exp;
        private DevExpress.XtraEditors.DateEdit txt_date_of_importing;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel_customer_home;
        private System.Windows.Forms.Label label21;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_show;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_more;
        private DevExpress.XtraEditors.SimpleButton btn_remove;
        private System.Windows.Forms.Panel panel1;
     //   private DevExpress.XtraEditors.ComboBoxEdit cmb_catagory;
        private DevExpress.XtraEditors.TextEdit txt_pro_name;
        private System.Windows.Forms.ComboBox cmb_catagory;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmb_brand;
        private System.Windows.Forms.Panel panel2;
    }
}
