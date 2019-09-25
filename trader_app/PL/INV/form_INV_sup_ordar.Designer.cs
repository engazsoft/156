namespace trader_app.PL.INV
{
    partial class form_INV_sup_ordar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_to = new System.Windows.Forms.Label();
            this.cbx_Inv_from = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Accout_ID = new System.Windows.Forms.TextBox();
            this.label_num = new System.Windows.Forms.Label();
            this.txt_Account_A_N = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtb_mov_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Currency_key = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_insert_to_dg = new System.Windows.Forms.Button();
            this.txt_tran_Num = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbx_insrt_form = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_refer_num = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.cbx_cost_canter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_curr_exch_rate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_curr_exch_rate_inv = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label_nem = new System.Windows.Forms.Label();
            this.txt_Car_num = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_Driver_A_N = new System.Windows.Forms.TextBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.chbx_deported = new System.Windows.Forms.CheckBox();
            this.chbx_stope = new System.Windows.Forms.CheckBox();
            this.dgv_mov_line = new System.Windows.Forms.DataGridView();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_curr_name = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mov_line)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(578, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.Text = "رقم التوريد";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.Location = new System.Drawing.Point(402, 19);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.ReadOnly = true;
            this.txt_id.Tag = "inst_num";
            this.txt_id.Text = "<جديد>";
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 433);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(974, 54);
            // 
            // txt_edit_user
            // 
            this.txt_edit_user.Margin = new System.Windows.Forms.Padding(4);
            // 
            // txt_edit_date
            // 
            this.txt_edit_date.Margin = new System.Windows.Forms.Padding(4);
            // 
            // txt_in_date
            // 
            this.txt_in_date.Margin = new System.Windows.Forms.Padding(4);
            // 
            // txt_by_user
            // 
            this.txt_by_user.Margin = new System.Windows.Forms.Padding(4);
            // 
            // groupBox2
            // 
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(94, 433);
            // 
            // btn_repeal
            // 
            this.btn_repeal.Location = new System.Drawing.Point(6, 180);
            this.btn_repeal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_repeal.Size = new System.Drawing.Size(82, 23);
            // 
            // btn_dele
            // 
            this.btn_dele.Location = new System.Drawing.Point(6, 157);
            this.btn_dele.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dele.Size = new System.Drawing.Size(82, 23);
            // 
            // btn_serch
            // 
            this.btn_serch.Location = new System.Drawing.Point(6, 134);
            this.btn_serch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_serch.Size = new System.Drawing.Size(82, 23);
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(6, 111);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Size = new System.Drawing.Size(82, 23);
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_seve
            // 
            this.btn_seve.Location = new System.Drawing.Point(6, 88);
            this.btn_seve.Margin = new System.Windows.Forms.Padding(4);
            this.btn_seve.Size = new System.Drawing.Size(82, 23);
            this.btn_seve.Click += new System.EventHandler(this.btn_seve_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(6, 65);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Size = new System.Drawing.Size(82, 23);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(6, 42);
            this.btn_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_view.Size = new System.Drawing.Size(82, 23);
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 19);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Size = new System.Drawing.Size(82, 23);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.chbx_deported);
            this.groupBox_Data.Controls.Add(this.chbx_stope);
            this.groupBox_Data.Controls.Add(this.txt_Note);
            this.groupBox_Data.Controls.Add(this.label23);
            this.groupBox_Data.Controls.Add(this.txt_Driver_A_N);
            this.groupBox_Data.Controls.Add(this.label21);
            this.groupBox_Data.Controls.Add(this.txt_Car_num);
            this.groupBox_Data.Controls.Add(this.label20);
            this.groupBox_Data.Controls.Add(this.label_nem);
            this.groupBox_Data.Controls.Add(this.txt_name);
            this.groupBox_Data.Controls.Add(this.txt_curr_exch_rate_inv);
            this.groupBox_Data.Controls.Add(this.label15);
            this.groupBox_Data.Controls.Add(this.txt_curr_exch_rate);
            this.groupBox_Data.Controls.Add(this.label14);
            this.groupBox_Data.Controls.Add(this.txt_num);
            this.groupBox_Data.Controls.Add(this.txt_refer_num);
            this.groupBox_Data.Controls.Add(this.label13);
            this.groupBox_Data.Controls.Add(this.txt_Currency_key);
            this.groupBox_Data.Controls.Add(this.label8);
            this.groupBox_Data.Controls.Add(this.label2);
            this.groupBox_Data.Controls.Add(this.label10);
            this.groupBox_Data.Controls.Add(this.cbx_cost_canter);
            this.groupBox_Data.Controls.Add(this.label_num);
            this.groupBox_Data.Controls.Add(this.txt_Account_A_N);
            this.groupBox_Data.Controls.Add(this.label3);
            this.groupBox_Data.Controls.Add(this.dtb_mov_date);
            this.groupBox_Data.Controls.Add(this.txt_Accout_ID);
            this.groupBox_Data.Controls.Add(this.label1);
            this.groupBox_Data.Controls.Add(this.label_to);
            this.groupBox_Data.Controls.Add(this.cbx_Inv_from);
            this.groupBox_Data.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_Data.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_Data.Size = new System.Drawing.Size(880, 167);
            this.groupBox_Data.TabIndex = 0;
            this.groupBox_Data.Controls.SetChildIndex(this.cbx_Inv_from, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label_to, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label1, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_Accout_ID, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.dtb_mov_date, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label3, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_Account_A_N, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label_num, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.cbx_cost_canter, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label10, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label2, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label8, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_Currency_key, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label13, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_refer_num, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_num, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label14, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_curr_exch_rate, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label15, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_curr_exch_rate_inv, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_name, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label_nem, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_id, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label9, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label20, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_Car_num, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label21, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_Driver_A_N, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.label23, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.txt_Note, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.chbx_stope, 0);
            this.groupBox_Data.Controls.SetChildIndex(this.chbx_deported, 0);
            // 
            // btn_ifect_account
            // 
            this.btn_ifect_account.Location = new System.Drawing.Point(6, 203);
            this.btn_ifect_account.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ifect_account.Size = new System.Drawing.Size(82, 23);
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(805, 19);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(39, 13);
            this.label_to.TabIndex = 5;
            this.label_to.Text = "المخزن";
            // 
            // cbx_Inv_from
            // 
            this.cbx_Inv_from.FormattingEnabled = true;
            this.cbx_Inv_from.Location = new System.Drawing.Point(638, 19);
            this.cbx_Inv_from.Name = "cbx_Inv_from";
            this.cbx_Inv_from.Size = new System.Drawing.Size(160, 21);
            this.cbx_Inv_from.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "رقم الحساب";
            // 
            // txt_Accout_ID
            // 
            this.txt_Accout_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Accout_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Accout_ID.Location = new System.Drawing.Point(724, 46);
            this.txt_Accout_ID.Name = "txt_Accout_ID";
            this.txt_Accout_ID.Size = new System.Drawing.Size(75, 20);
            this.txt_Accout_ID.TabIndex = 2;
            this.txt_Accout_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Accout_ID_KeyDown);
            this.txt_Accout_ID.Leave += new System.EventHandler(this.txt_Accout_ID_Leave);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(337, 48);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(107, 13);
            this.label_num.TabIndex = 13;
            this.label_num.Text = "رقم الحساب التحليلي";
            this.label_num.Visible = false;
            // 
            // txt_Account_A_N
            // 
            this.txt_Account_A_N.Location = new System.Drawing.Point(415, 46);
            this.txt_Account_A_N.Name = "txt_Account_A_N";
            this.txt_Account_A_N.Size = new System.Drawing.Size(238, 20);
            this.txt_Account_A_N.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "تاريخ التوريد";
            // 
            // dtb_mov_date
            // 
            this.dtb_mov_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_mov_date.Location = new System.Drawing.Point(177, 16);
            this.dtb_mov_date.Name = "dtb_mov_date";
            this.dtb_mov_date.Size = new System.Drawing.Size(153, 20);
            this.dtb_mov_date.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "اسم الحساب";
            // 
            // txt_Currency_key
            // 
            this.txt_Currency_key.Location = new System.Drawing.Point(724, 74);
            this.txt_Currency_key.Name = "txt_Currency_key";
            this.txt_Currency_key.Size = new System.Drawing.Size(78, 20);
            this.txt_Currency_key.TabIndex = 16;
            this.txt_Currency_key.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_Currency_key.Enter += new System.EventHandler(this.txt_Currency_key_Enter);
            this.txt_Currency_key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Currency_key_KeyDown);
            this.txt_Currency_key.Leave += new System.EventHandler(this.txt_Currency_key_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(805, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "العملة";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btn_insert_to_dg);
            this.groupBox3.Controls.Add(this.txt_tran_Num);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.cbx_insrt_form);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(94, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(880, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "انزال الاصناف والسعر";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "النزال ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_insert_to_dg
            // 
            this.btn_insert_to_dg.Location = new System.Drawing.Point(157, 11);
            this.btn_insert_to_dg.Name = "btn_insert_to_dg";
            this.btn_insert_to_dg.Size = new System.Drawing.Size(75, 23);
            this.btn_insert_to_dg.TabIndex = 28;
            this.btn_insert_to_dg.Text = "النزال ";
            this.btn_insert_to_dg.UseVisualStyleBackColor = true;
            this.btn_insert_to_dg.Click += new System.EventHandler(this.btn_insert_to_dg_Click);
            // 
            // txt_tran_Num
            // 
            this.txt_tran_Num.Location = new System.Drawing.Point(238, 13);
            this.txt_tran_Num.Name = "txt_tran_Num";
            this.txt_tran_Num.Size = new System.Drawing.Size(115, 20);
            this.txt_tran_Num.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(443, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(360, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "رقم المستند";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(609, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "طريقة تكاليف الاصناف";
            // 
            // cbx_insrt_form
            // 
            this.cbx_insrt_form.FormattingEnabled = true;
            this.cbx_insrt_form.Location = new System.Drawing.Point(443, 11);
            this.cbx_insrt_form.Name = "cbx_insrt_form";
            this.cbx_insrt_form.Size = new System.Drawing.Size(160, 21);
            this.cbx_insrt_form.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(609, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "انزال الاصناف من";
            // 
            // txt_refer_num
            // 
            this.txt_refer_num.Location = new System.Drawing.Point(724, 104);
            this.txt_refer_num.Name = "txt_refer_num";
            this.txt_refer_num.Size = new System.Drawing.Size(78, 20);
            this.txt_refer_num.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(805, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "رقم المرجع";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(248, 45);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(83, 20);
            this.txt_num.TabIndex = 19;
            this.txt_num.Visible = false;
            this.txt_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_num_KeyDown);
            // 
            // cbx_cost_canter
            // 
            this.cbx_cost_canter.FormattingEnabled = true;
            this.cbx_cost_canter.Location = new System.Drawing.Point(177, 71);
            this.cbx_cost_canter.Name = "cbx_cost_canter";
            this.cbx_cost_canter.Size = new System.Drawing.Size(160, 21);
            this.cbx_cost_canter.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "مركز التكلفة";
            // 
            // txt_curr_exch_rate
            // 
            this.txt_curr_exch_rate.Location = new System.Drawing.Point(570, 74);
            this.txt_curr_exch_rate.Name = "txt_curr_exch_rate";
            this.txt_curr_exch_rate.Size = new System.Drawing.Size(83, 20);
            this.txt_curr_exch_rate.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(659, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "س.ت.حساب";
            // 
            // txt_curr_exch_rate_inv
            // 
            this.txt_curr_exch_rate_inv.Location = new System.Drawing.Point(415, 74);
            this.txt_curr_exch_rate_inv.Name = "txt_curr_exch_rate_inv";
            this.txt_curr_exch_rate_inv.Size = new System.Drawing.Size(83, 20);
            this.txt_curr_exch_rate_inv.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(500, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "س.ت.مخزون";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(6, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 20);
            this.txt_name.TabIndex = 24;
            this.txt_name.Visible = false;
            // 
            // label_nem
            // 
            this.label_nem.AutoSize = true;
            this.label_nem.Location = new System.Drawing.Point(208, 48);
            this.label_nem.Name = "label_nem";
            this.label_nem.Size = new System.Drawing.Size(39, 13);
            this.label_nem.TabIndex = 25;
            this.label_nem.Text = "الاسم ";
            this.label_nem.Visible = false;
            // 
            // txt_Car_num
            // 
            this.txt_Car_num.Location = new System.Drawing.Point(639, 138);
            this.txt_Car_num.Name = "txt_Car_num";
            this.txt_Car_num.Size = new System.Drawing.Size(163, 20);
            this.txt_Car_num.TabIndex = 27;
            this.txt_Car_num.TextChanged += new System.EventHandler(this.txt_Car_num_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(805, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "رقم السيارة";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(542, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "اسم السائق";
            // 
            // txt_Driver_A_N
            // 
            this.txt_Driver_A_N.Location = new System.Drawing.Point(233, 141);
            this.txt_Driver_A_N.Name = "txt_Driver_A_N";
            this.txt_Driver_A_N.Size = new System.Drawing.Size(303, 20);
            this.txt_Driver_A_N.TabIndex = 27;
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(415, 107);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(266, 20);
            this.txt_Note.TabIndex = 29;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(687, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "البيان";
            // 
            // chbx_deported
            // 
            this.chbx_deported.AutoSize = true;
            this.chbx_deported.Enabled = false;
            this.chbx_deported.Location = new System.Drawing.Point(241, 108);
            this.chbx_deported.Name = "chbx_deported";
            this.chbx_deported.Size = new System.Drawing.Size(52, 17);
            this.chbx_deported.TabIndex = 31;
            this.chbx_deported.Text = "مرحل";
            this.chbx_deported.UseVisualStyleBackColor = true;
            // 
            // chbx_stope
            // 
            this.chbx_stope.AutoSize = true;
            this.chbx_stope.Location = new System.Drawing.Point(323, 109);
            this.chbx_stope.Name = "chbx_stope";
            this.chbx_stope.Size = new System.Drawing.Size(88, 17);
            this.chbx_stope.TabIndex = 30;
            this.chbx_stope.Text = "تعليق العملة ";
            this.chbx_stope.UseVisualStyleBackColor = true;
            // 
            // dgv_mov_line
            // 
            this.dgv_mov_line.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_mov_line.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_mov_line.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mov_line.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M,
            this.product_ID,
            this.A_N,
            this.Product_disc,
            this.Unit,
            this.Quantity,
            this.cost,
            this.sumcost});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(77)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_mov_line.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_mov_line.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_mov_line.Location = new System.Drawing.Point(94, 255);
            this.dgv_mov_line.MultiSelect = false;
            this.dgv_mov_line.Name = "dgv_mov_line";
            this.dgv_mov_line.Size = new System.Drawing.Size(880, 145);
            this.dgv_mov_line.TabIndex = 1;
            this.dgv_mov_line.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mov_line_CellContentClick);
            this.dgv_mov_line.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mov_line_CellEndEdit);
            this.dgv_mov_line.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mov_line_CellEnter);
            this.dgv_mov_line.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_mov_line_RowsAdded);
            this.dgv_mov_line.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_mov_line_KeyDown);
            // 
            // M
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.M.DefaultCellStyle = dataGridViewCellStyle2;
            this.M.Frozen = true;
            this.M.HeaderText = "م";
            this.M.Name = "M";
            this.M.Width = 40;
            // 
            // product_ID
            // 
            this.product_ID.HeaderText = "رقم المنتج";
            this.product_ID.Name = "product_ID";
            // 
            // A_N
            // 
            this.A_N.HeaderText = "اسم المنتج";
            this.A_N.Name = "A_N";
            this.A_N.Width = 200;
            // 
            // Product_disc
            // 
            this.Product_disc.HeaderText = "وصف المنتج";
            this.Product_disc.Name = "Product_disc";
            this.Product_disc.Width = 200;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "الوحدة";
            this.Unit.Name = "Unit";
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.Name = "Quantity";
            // 
            // cost
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.cost.DefaultCellStyle = dataGridViewCellStyle3;
            this.cost.HeaderText = "التكلفة";
            this.cost.Name = "cost";
            // 
            // sumcost
            // 
            dataGridViewCellStyle4.NullValue = "0";
            this.sumcost.DefaultCellStyle = dataGridViewCellStyle4;
            this.sumcost.HeaderText = "اجمالي التكلفة";
            this.sumcost.Name = "sumcost";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_curr_name);
            this.panel1.Controls.Add(this.txt_cost);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(94, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 33);
            this.panel1.TabIndex = 20;
            // 
            // lb_curr_name
            // 
            this.lb_curr_name.AutoSize = true;
            this.lb_curr_name.Location = new System.Drawing.Point(51, 9);
            this.lb_curr_name.Name = "lb_curr_name";
            this.lb_curr_name.Size = new System.Drawing.Size(41, 13);
            this.lb_curr_name.TabIndex = 29;
            this.lb_curr_name.Text = "label24";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(108, 9);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(145, 20);
            this.txt_cost.TabIndex = 28;
            this.txt_cost.TextChanged += new System.EventHandler(this.txt_cost_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(258, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "اجمالي التكلفة";
            // 
            // form_INV_sup_ordar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_mov_line);
            this.Controls.Add(this.groupBox3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "form_INV_sup_ordar";
            this.Tag = "AC_instrument";
            this.Text = "امر توريد مخزني";
            this.Load += new System.EventHandler(this.form_INV_sup_ordar_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox_Data, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.dgv_mov_line, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mov_line)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.ComboBox cbx_Inv_from;
        private System.Windows.Forms.TextBox txt_Accout_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.TextBox txt_Account_A_N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtb_mov_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Currency_key;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_refer_num;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_cost_canter;
        private System.Windows.Forms.Label label_nem;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_curr_exch_rate_inv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_curr_exch_rate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_insert_to_dg;
        private System.Windows.Forms.TextBox txt_tran_Num;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbx_insrt_form;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_Driver_A_N;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_Car_num;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox chbx_deported;
        private System.Windows.Forms.CheckBox chbx_stope;
        private System.Windows.Forms.DataGridView dgv_mov_line;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumcost;
        private System.Windows.Forms.Label lb_curr_name;
    }
}