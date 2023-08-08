
namespace nilu_project_001
{
    partial class UC_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remove = new DevExpress.XtraEditors.SimpleButton();
            this.btn_more = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.panel_customer_home = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_state = new System.Windows.Forms.ComboBox();
            this.txt_invoice_no = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gst_no = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_gmail = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_contact = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_par_add = new System.Windows.Forms.TextBox();
            this.txt_current_add = new System.Windows.Forms.TextBox();
            this.txt_DOB = new DevExpress.XtraEditors.DateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Sname = new DevExpress.XtraEditors.TextEdit();
            this.txt_Mname = new DevExpress.XtraEditors.TextEdit();
            this.txt_Fnme = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clk_same_address = new System.Windows.Forms.CheckBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_show = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.panel_customer_home.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_invoice_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gst_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fnme.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGV_Customer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 335);
            this.panel1.TabIndex = 2;
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.AllowUserToOrderColumns = true;
            this.DGV_Customer.AllowUserToResizeRows = false;
            this.DGV_Customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGV_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DGV_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Customer.Location = new System.Drawing.Point(0, 0);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.Size = new System.Drawing.Size(934, 335);
            this.DGV_Customer.TabIndex = 0;
            this.DGV_Customer.DoubleClick += new System.EventHandler(this.DGV_Customer_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Of Birth";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contact";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gmail";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "State";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Permanent Address";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Gst No";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Invoice No";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "User Name";
            this.Column10.Name = "Column10";
            // 
            // btn_remove
            // 
            this.btn_remove.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_remove.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_remove.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_remove.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_remove.Appearance.Options.UseBackColor = true;
            this.btn_remove.Appearance.Options.UseBorderColor = true;
            this.btn_remove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_remove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_remove.ImageOptions.SvgImage")));
            this.btn_remove.Location = new System.Drawing.Point(2, 287);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(185, 38);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Remove";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_more
            // 
            this.btn_more.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_more.Appearance.Options.UseBackColor = true;
            this.btn_more.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_more.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_more.ImageOptions.SvgImage")));
            this.btn_more.Location = new System.Drawing.Point(188, 287);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(185, 38);
            this.btn_more.TabIndex = 2;
            this.btn_more.Text = "Add";
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_update.Appearance.Options.UseBackColor = true;
            this.btn_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(374, 287);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(185, 38);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel_customer_home
            // 
            this.panel_customer_home.Controls.Add(this.groupBox1);
            this.panel_customer_home.Controls.Add(this.btn_search);
            this.panel_customer_home.Controls.Add(this.btn_show);
            this.panel_customer_home.Controls.Add(this.btn_update);
            this.panel_customer_home.Controls.Add(this.btn_more);
            this.panel_customer_home.Controls.Add(this.btn_remove);
            this.panel_customer_home.Controls.Add(this.panel1);
            this.panel_customer_home.Location = new System.Drawing.Point(0, 0);
            this.panel_customer_home.Name = "panel_customer_home";
            this.panel_customer_home.Size = new System.Drawing.Size(934, 668);
            this.panel_customer_home.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_state);
            this.groupBox1.Controls.Add(this.txt_invoice_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_gst_no);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_gmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_contact);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_par_add);
            this.groupBox1.Controls.Add(this.txt_current_add);
            this.groupBox1.Controls.Add(this.txt_DOB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Sname);
            this.groupBox1.Controls.Add(this.txt_Mname);
            this.groupBox1.Controls.Add(this.txt_Fnme);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clk_same_address);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Detail";
            // 
            // txt_state
            // 
            this.txt_state.FormattingEnabled = true;
            this.txt_state.Location = new System.Drawing.Point(620, 116);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(148, 21);
            this.txt_state.TabIndex = 29;
            // 
            // txt_invoice_no
            // 
            this.txt_invoice_no.Location = new System.Drawing.Point(620, 21);
            this.txt_invoice_no.Name = "txt_invoice_no";
            this.txt_invoice_no.Size = new System.Drawing.Size(269, 20);
            this.txt_invoice_no.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Invoice NO :";
            // 
            // txt_gst_no
            // 
            this.txt_gst_no.Location = new System.Drawing.Point(188, 21);
            this.txt_gst_no.Name = "txt_gst_no";
            this.txt_gst_no.Size = new System.Drawing.Size(294, 20);
            this.txt_gst_no.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Gst NO :";
            // 
            // txt_gmail
            // 
            this.txt_gmail.Location = new System.Drawing.Point(620, 84);
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.Size = new System.Drawing.Size(269, 20);
            this.txt_gmail.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(557, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Gmail";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(620, 53);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(269, 20);
            this.txt_contact.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Contact";
            // 
            // txt_par_add
            // 
            this.txt_par_add.Location = new System.Drawing.Point(575, 179);
            this.txt_par_add.Multiline = true;
            this.txt_par_add.Name = "txt_par_add";
            this.txt_par_add.Size = new System.Drawing.Size(313, 56);
            this.txt_par_add.TabIndex = 11;
            // 
            // txt_current_add
            // 
            this.txt_current_add.Location = new System.Drawing.Point(188, 179);
            this.txt_current_add.Multiline = true;
            this.txt_current_add.Name = "txt_current_add";
            this.txt_current_add.Size = new System.Drawing.Size(265, 56);
            this.txt_current_add.TabIndex = 9;
            // 
            // txt_DOB
            // 
            this.txt_DOB.EditValue = null;
            this.txt_DOB.Location = new System.Drawing.Point(188, 147);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_DOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_DOB.Size = new System.Drawing.Size(294, 20);
            this.txt_DOB.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mid Name";
            // 
            // txt_Sname
            // 
            this.txt_Sname.Location = new System.Drawing.Point(188, 116);
            this.txt_Sname.Name = "txt_Sname";
            this.txt_Sname.Size = new System.Drawing.Size(294, 20);
            this.txt_Sname.TabIndex = 3;
            // 
            // txt_Mname
            // 
            this.txt_Mname.Location = new System.Drawing.Point(188, 84);
            this.txt_Mname.Name = "txt_Mname";
            this.txt_Mname.Size = new System.Drawing.Size(294, 20);
            this.txt_Mname.TabIndex = 2;
            // 
            // txt_Fnme
            // 
            this.txt_Fnme.Location = new System.Drawing.Point(188, 53);
            this.txt_Fnme.Name = "txt_Fnme";
            this.txt_Fnme.Size = new System.Drawing.Size(294, 20);
            this.txt_Fnme.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "State ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Parmanant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address Current";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // clk_same_address
            // 
            this.clk_same_address.AutoSize = true;
            this.clk_same_address.Location = new System.Drawing.Point(470, 229);
            this.clk_same_address.Name = "clk_same_address";
            this.clk_same_address.Size = new System.Drawing.Size(223, 30);
            this.clk_same_address.TabIndex = 10;
            this.clk_same_address.Text = "Click if\r\nCurrent And Parmanant Address Is Same";
            this.clk_same_address.UseVisualStyleBackColor = true;
            this.clk_same_address.CheckedChanged += new System.EventHandler(this.clk_same_address_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_search.Appearance.Options.UseBackColor = true;
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(746, 287);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(185, 38);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            // 
            // btn_show
            // 
            this.btn_show.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_show.Appearance.Options.UseBackColor = true;
            this.btn_show.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_show.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_show.ImageOptions.SvgImage")));
            this.btn_show.Location = new System.Drawing.Point(560, 287);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(185, 38);
            this.btn_show.TabIndex = 4;
            this.btn_show.Text = "Save";
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // UC_Customer
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_customer_home);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(934, 668);
            this.Load += new System.EventHandler(this.UC_Customer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.panel_customer_home.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_invoice_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gst_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fnme.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_Customer;
        private DevExpress.XtraEditors.SimpleButton btn_remove;
        private DevExpress.XtraEditors.SimpleButton btn_more;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private System.Windows.Forms.Panel panel_customer_home;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_show;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txt_gmail;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txt_contact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_par_add;
        private System.Windows.Forms.TextBox txt_current_add;
        private DevExpress.XtraEditors.DateEdit txt_DOB;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txt_Sname;
        private DevExpress.XtraEditors.TextEdit txt_Mname;
        private DevExpress.XtraEditors.TextEdit txt_Fnme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox clk_same_address;
        private DevExpress.XtraEditors.TextEdit txt_invoice_no;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_gst_no;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ComboBox txt_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}
