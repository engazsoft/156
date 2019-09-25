namespace trader_app.PL.INV
{
    partial class frm_Product
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Available = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chbx_Service_category = new System.Windows.Forms.CheckBox();
            this.txt_default_price = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.chbx_stop = new System.Windows.Forms.CheckBox();
            this.chbx_booked = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_Units = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_barcod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.off = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_Up_request = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_Opening_stock = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_down_request = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_request = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbx_Units = new System.Windows.Forms.ComboBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_Manufacturing_number = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_Product_Parent_ID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_Disc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv1 = new trader_app.CU.dgv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_view_mov = new System.Windows.Forms.Button();
            this.dtb_to = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtb_frm = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Bracod_num = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_E_N = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_A_N = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Product_Category = new System.Windows.Forms.ComboBox();
            this.cbx_Product_Type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Units)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 482);
            this.groupBox1.Size = new System.Drawing.Size(798, 60);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_edit_user
            // 
            this.txt_edit_user.BackColor = System.Drawing.Color.White;
            this.txt_edit_user.ReadOnly = true;
            // 
            // txt_edit_date
            // 
            this.txt_edit_date.BackColor = System.Drawing.Color.White;
            this.txt_edit_date.ReadOnly = true;
            // 
            // txt_in_date
            // 
            this.txt_in_date.BackColor = System.Drawing.Color.White;
            this.txt_in_date.ReadOnly = true;
            // 
            // txt_by_user
            // 
            this.txt_by_user.BackColor = System.Drawing.Color.White;
            this.txt_by_user.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(94, 482);
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_serch
            // 
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // btn_seve
            // 
            this.btn_seve.Click += new System.EventHandler(this.btn_seve_Click);
            // 
            // btn_view
            // 
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_add
            // 
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.panel2);
            this.groupBox_Data.Controls.Add(this.panel1);
            this.groupBox_Data.Size = new System.Drawing.Size(704, 482);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 378);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Available);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.chbx_Service_category);
            this.tabPage1.Controls.Add(this.txt_default_price);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.chbx_stop);
            this.tabPage1.Controls.Add(this.chbx_booked);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.txt_Amount);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.txt_Up_request);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.txt_Opening_stock);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.txt_down_request);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txt_request);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.cbx_Units);
            this.tabPage1.Controls.Add(this.txt_cost);
            this.tabPage1.Controls.Add(this.txt_Manufacturing_number);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.txt_Product_Parent_ID);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.txt_Disc);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.pic_product);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "بيانات الصنف";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_Available
            // 
            this.txt_Available.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_Available.Location = new System.Drawing.Point(436, 39);
            this.txt_Available.Name = "txt_Available";
            this.txt_Available.ReadOnly = true;
            this.txt_Available.Size = new System.Drawing.Size(174, 20);
            this.txt_Available.TabIndex = 27;
            this.txt_Available.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(613, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "الكمية المتوفرة";
            // 
            // chbx_Service_category
            // 
            this.chbx_Service_category.AutoSize = true;
            this.chbx_Service_category.Location = new System.Drawing.Point(152, 303);
            this.chbx_Service_category.Name = "chbx_Service_category";
            this.chbx_Service_category.Size = new System.Drawing.Size(82, 17);
            this.chbx_Service_category.TabIndex = 25;
            this.chbx_Service_category.Text = "صنف خدمي";
            this.chbx_Service_category.UseVisualStyleBackColor = true;
            // 
            // txt_default_price
            // 
            this.txt_default_price.Location = new System.Drawing.Point(7, 162);
            this.txt_default_price.Name = "txt_default_price";
            this.txt_default_price.Size = new System.Drawing.Size(174, 20);
            this.txt_default_price.TabIndex = 24;
            this.txt_default_price.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(187, 165);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "السعر الافتراضي";
            // 
            // chbx_stop
            // 
            this.chbx_stop.AutoSize = true;
            this.chbx_stop.Location = new System.Drawing.Point(139, 257);
            this.chbx_stop.Name = "chbx_stop";
            this.chbx_stop.Size = new System.Drawing.Size(88, 17);
            this.chbx_stop.TabIndex = 22;
            this.chbx_stop.Text = "غير قابل للبيع";
            this.chbx_stop.UseVisualStyleBackColor = true;
            this.chbx_stop.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chbx_booked
            // 
            this.chbx_booked.AutoSize = true;
            this.chbx_booked.Location = new System.Drawing.Point(142, 280);
            this.chbx_booked.Name = "chbx_booked";
            this.chbx_booked.Size = new System.Drawing.Size(87, 17);
            this.chbx_booked.TabIndex = 21;
            this.chbx_booked.Text = "الصنف محجوز";
            this.chbx_booked.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(642, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "التكلفة";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_Units);
            this.groupBox3.Location = new System.Drawing.Point(281, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 192);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الوحدات";
            // 
            // dgv_Units
            // 
            this.dgv_Units.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Units.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_ID,
            this.P_barcod,
            this.Units,
            this.Amount,
            this.off});
            this.dgv_Units.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Units.Location = new System.Drawing.Point(3, 16);
            this.dgv_Units.Name = "dgv_Units";
            this.dgv_Units.Size = new System.Drawing.Size(386, 173);
            this.dgv_Units.TabIndex = 1;
            this.dgv_Units.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Units_CellEndEdit);
            this.dgv_Units.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Units_CellLeave);
            this.dgv_Units.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Units_CellValueChanged);
            this.dgv_Units.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Units_KeyDown);
            this.dgv_Units.Leave += new System.EventHandler(this.dgv_Units_Leave);
            // 
            // P_ID
            // 
            this.P_ID.HeaderText = "رقم الصنف";
            this.P_ID.Name = "P_ID";
            // 
            // P_barcod
            // 
            this.P_barcod.HeaderText = "رقم الباركود";
            this.P_barcod.Name = "P_barcod";
            // 
            // Units
            // 
            this.Units.HeaderText = "الوحدة";
            this.Units.Name = "Units";
            this.Units.Width = 50;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "العبوة";
            this.Amount.Name = "Amount";
            this.Amount.Width = 50;
            // 
            // off
            // 
            this.off.HeaderText = "توقيف";
            this.off.Name = "off";
            this.off.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.off.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.off.Width = 50;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(437, 117);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.ReadOnly = true;
            this.txt_Amount.Size = new System.Drawing.Size(174, 20);
            this.txt_Amount.TabIndex = 18;
            this.txt_Amount.Text = "1";
            this.txt_Amount.TextChanged += new System.EventHandler(this.txt_Amount_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(626, 122);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "العبوة";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // txt_Up_request
            // 
            this.txt_Up_request.Location = new System.Drawing.Point(182, 91);
            this.txt_Up_request.Name = "txt_Up_request";
            this.txt_Up_request.Size = new System.Drawing.Size(174, 20);
            this.txt_Up_request.TabIndex = 18;
            this.txt_Up_request.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(355, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "اعلا حد ";
            // 
            // txt_Opening_stock
            // 
            this.txt_Opening_stock.Location = new System.Drawing.Point(182, 13);
            this.txt_Opening_stock.Name = "txt_Opening_stock";
            this.txt_Opening_stock.ReadOnly = true;
            this.txt_Opening_stock.Size = new System.Drawing.Size(174, 20);
            this.txt_Opening_stock.TabIndex = 16;
            this.txt_Opening_stock.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(359, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "الكمة الافتتاحية";
            // 
            // txt_down_request
            // 
            this.txt_down_request.Location = new System.Drawing.Point(182, 66);
            this.txt_down_request.Name = "txt_down_request";
            this.txt_down_request.Size = new System.Drawing.Size(174, 20);
            this.txt_down_request.TabIndex = 14;
            this.txt_down_request.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(355, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "الحد الادنا للطلب ";
            // 
            // txt_request
            // 
            this.txt_request.Location = new System.Drawing.Point(182, 42);
            this.txt_request.Name = "txt_request";
            this.txt_request.Size = new System.Drawing.Size(174, 20);
            this.txt_request.TabIndex = 12;
            this.txt_request.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(362, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "كمة الطلب ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(642, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "الوحدة";
            // 
            // cbx_Units
            // 
            this.cbx_Units.FormattingEnabled = true;
            this.cbx_Units.Location = new System.Drawing.Point(436, 92);
            this.cbx_Units.Name = "cbx_Units";
            this.cbx_Units.Size = new System.Drawing.Size(174, 21);
            this.cbx_Units.TabIndex = 9;
            this.cbx_Units.SelectedIndexChanged += new System.EventHandler(this.cbx_Units_SelectedIndexChanged);
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(436, 10);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(174, 20);
            this.txt_cost.TabIndex = 8;
            this.txt_cost.Text = "0";
            // 
            // txt_Manufacturing_number
            // 
            this.txt_Manufacturing_number.Location = new System.Drawing.Point(7, 225);
            this.txt_Manufacturing_number.Name = "txt_Manufacturing_number";
            this.txt_Manufacturing_number.Size = new System.Drawing.Size(174, 20);
            this.txt_Manufacturing_number.TabIndex = 4;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(196, 228);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "رقم التصنيع";
            this.label25.Click += new System.EventHandler(this.label14_Click);
            // 
            // txt_Product_Parent_ID
            // 
            this.txt_Product_Parent_ID.Location = new System.Drawing.Point(7, 188);
            this.txt_Product_Parent_ID.Name = "txt_Product_Parent_ID";
            this.txt_Product_Parent_ID.Size = new System.Drawing.Size(174, 20);
            this.txt_Product_Parent_ID.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(196, 191);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "الصنف الاعلى";
            this.label22.Click += new System.EventHandler(this.label14_Click);
            // 
            // txt_Disc
            // 
            this.txt_Disc.Location = new System.Drawing.Point(436, 67);
            this.txt_Disc.Name = "txt_Disc";
            this.txt_Disc.Size = new System.Drawing.Size(174, 20);
            this.txt_Disc.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(625, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "وصف الصنف";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pic_product
            // 
            this.pic_product.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_product.Location = new System.Drawing.Point(7, 6);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(151, 129);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_product.TabIndex = 0;
            this.pic_product.TabStop = false;
            this.pic_product.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "الموردون";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(681, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "الحركة";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 198);
            this.panel4.TabIndex = 1;
            // 
            // dgv1
            // 
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(675, 198);
            this.dgv1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_view_mov);
            this.panel3.Controls.Add(this.dtb_to);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dtb_frm);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 64);
            this.panel3.TabIndex = 0;
            // 
            // btn_view_mov
            // 
            this.btn_view_mov.Location = new System.Drawing.Point(23, 9);
            this.btn_view_mov.Name = "btn_view_mov";
            this.btn_view_mov.Size = new System.Drawing.Size(75, 23);
            this.btn_view_mov.TabIndex = 2;
            this.btn_view_mov.Text = "عرض";
            this.btn_view_mov.UseVisualStyleBackColor = true;
            this.btn_view_mov.Click += new System.EventHandler(this.btn_view_mov_Click);
            // 
            // dtb_to
            // 
            this.dtb_to.CustomFormat = "yyyy-MM-dd";
            this.dtb_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtb_to.Location = new System.Drawing.Point(403, 13);
            this.dtb_to.Name = "dtb_to";
            this.dtb_to.Size = new System.Drawing.Size(98, 20);
            this.dtb_to.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(507, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "الى";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtb_frm
            // 
            this.dtb_frm.CustomFormat = "yyyy-MM-dd";
            this.dtb_frm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtb_frm.Location = new System.Drawing.Point(584, 13);
            this.dtb_frm.Name = "dtb_frm";
            this.dtb_frm.Size = new System.Drawing.Size(98, 20);
            this.dtb_frm.TabIndex = 0;
            this.dtb_frm.Value = new System.DateTime(2019, 1, 1, 19, 52, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(688, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "من تارخ ";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Bracod_num);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_E_N);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_A_N);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_Product_Category);
            this.panel1.Controls.Add(this.cbx_Product_Type);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 85);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_Bracod_num
            // 
            this.txt_Bracod_num.Location = new System.Drawing.Point(11, 4);
            this.txt_Bracod_num.Name = "txt_Bracod_num";
            this.txt_Bracod_num.Size = new System.Drawing.Size(269, 20);
            this.txt_Bracod_num.TabIndex = 6;
            this.txt_Bracod_num.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "رقم الباركود";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_E_N
            // 
            this.txt_E_N.Location = new System.Drawing.Point(11, 57);
            this.txt_E_N.Name = "txt_E_N";
            this.txt_E_N.Size = new System.Drawing.Size(269, 20);
            this.txt_E_N.TabIndex = 4;
            this.txt_E_N.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "الاسم الاجنبي ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_A_N
            // 
            this.txt_A_N.Location = new System.Drawing.Point(356, 57);
            this.txt_A_N.Name = "txt_A_N";
            this.txt_A_N.Size = new System.Drawing.Size(269, 20);
            this.txt_A_N.TabIndex = 2;
            this.txt_A_N.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "اسم الصنف";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(357, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(269, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.Tag = "Product_ID";
            this.txt_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            this.txt_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyUp);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "رقم الصنف";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم المجموعة";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نوع الصنف";
            // 
            // cbx_Product_Category
            // 
            this.cbx_Product_Category.AllowDrop = true;
            this.cbx_Product_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Product_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Product_Category.FormattingEnabled = true;
            this.cbx_Product_Category.Location = new System.Drawing.Point(356, 5);
            this.cbx_Product_Category.Name = "cbx_Product_Category";
            this.cbx_Product_Category.Size = new System.Drawing.Size(269, 21);
            this.cbx_Product_Category.TabIndex = 0;
            this.cbx_Product_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cbx_Product_Category.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbx_Product_Category_KeyUp);
            // 
            // cbx_Product_Type
            // 
            this.cbx_Product_Type.FormattingEnabled = true;
            this.cbx_Product_Type.Location = new System.Drawing.Point(10, 29);
            this.cbx_Product_Type.Name = "cbx_Product_Type";
            this.cbx_Product_Type.Size = new System.Drawing.Size(269, 21);
            this.cbx_Product_Type.TabIndex = 0;
            this.cbx_Product_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 542);
            this.Name = "frm_Product";
            this.Tag = "INV_Products";
            this.Text = "frm_Product";
            this.Load += new System.EventHandler(this.frm_Product_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_Product_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Units)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtb_to;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtb_frm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_view_mov;
        private CU.dgv dgv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Bracod_num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_E_N;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_A_N;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Product_Category;
        private System.Windows.Forms.ComboBox cbx_Product_Type;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_Available;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chbx_Service_category;
        private System.Windows.Forms.TextBox txt_default_price;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox chbx_stop;
        private System.Windows.Forms.CheckBox chbx_booked;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_barcod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn off;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_Up_request;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_Opening_stock;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_down_request;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_request;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbx_Units;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_Manufacturing_number;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_Product_Parent_ID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_Disc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pic_product;
    }
}