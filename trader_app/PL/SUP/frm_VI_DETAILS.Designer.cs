namespace trader_app.PL.SUP
{
    partial class frm_VI_DETAILS
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.cbx_currency = new System.Windows.Forms.ComboBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.txt_Product_ID_to = new System.Windows.Forms.TextBox();
            this.txt_V_CODE = new System.Windows.Forms.TextBox();
            this.txt_Product_ID = new System.Windows.Forms.TextBox();
            this.txt_V_CODE_to = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_V_curr = new System.Windows.Forms.DataGridView();
            this.V_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V_A_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_PACKING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_minor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_invantory_user = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_save_change = new System.Windows.Forms.Button();
            this.btn_show_user_branch = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_invantory_id2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_curr)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invantory_user)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 487);
            this.groupBox1.Size = new System.Drawing.Size(1064, 74);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(125, 487);
            // 
            // btn_repeal
            // 
            this.btn_repeal.Location = new System.Drawing.Point(4, 219);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.tabControl1);
            this.groupBox_Data.Size = new System.Drawing.Size(939, 487);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 19);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 464);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cbx_currency);
            this.tabPage1.Controls.Add(this.btn_enter);
            this.tabPage1.Controls.Add(this.txt_Product_ID_to);
            this.tabPage1.Controls.Add(this.txt_V_CODE);
            this.tabPage1.Controls.Add(this.txt_Product_ID);
            this.tabPage1.Controls.Add(this.txt_V_CODE_to);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.cbx_minor);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(923, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "البيانات الرئيسية";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(798, 118);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 120;
            this.label14.Text = "العملات";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_currency
            // 
            this.cbx_currency.FormattingEnabled = true;
            this.cbx_currency.Location = new System.Drawing.Point(482, 115);
            this.cbx_currency.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_currency.Name = "cbx_currency";
            this.cbx_currency.Size = new System.Drawing.Size(291, 24);
            this.cbx_currency.TabIndex = 119;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(256, 141);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(219, 34);
            this.btn_enter.TabIndex = 118;
            this.btn_enter.Text = "انزال البيانات";
            this.btn_enter.UseVisualStyleBackColor = true;
            // 
            // txt_Product_ID_to
            // 
            this.txt_Product_ID_to.Location = new System.Drawing.Point(92, 83);
            this.txt_Product_ID_to.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Product_ID_to.Name = "txt_Product_ID_to";
            this.txt_Product_ID_to.Size = new System.Drawing.Size(187, 22);
            this.txt_Product_ID_to.TabIndex = 90;
            this.txt_Product_ID_to.TextChanged += new System.EventHandler(this.txt_V_TAX_CODE_TextChanged);
            // 
            // txt_V_CODE
            // 
            this.txt_V_CODE.Location = new System.Drawing.Point(482, 54);
            this.txt_V_CODE.Margin = new System.Windows.Forms.Padding(4);
            this.txt_V_CODE.Name = "txt_V_CODE";
            this.txt_V_CODE.Size = new System.Drawing.Size(291, 22);
            this.txt_V_CODE.TabIndex = 87;
            this.txt_V_CODE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_V_CODE_KeyDown);
            // 
            // txt_Product_ID
            // 
            this.txt_Product_ID.Location = new System.Drawing.Point(482, 84);
            this.txt_Product_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Product_ID.Name = "txt_Product_ID";
            this.txt_Product_ID.Size = new System.Drawing.Size(291, 22);
            this.txt_Product_ID.TabIndex = 85;
            // 
            // txt_V_CODE_to
            // 
            this.txt_V_CODE_to.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_V_CODE_to.Location = new System.Drawing.Point(92, 51);
            this.txt_V_CODE_to.Margin = new System.Windows.Forms.Padding(4);
            this.txt_V_CODE_to.Name = "txt_V_CODE_to";
            this.txt_V_CODE_to.ReadOnly = true;
            this.txt_V_CODE_to.Size = new System.Drawing.Size(187, 22);
            this.txt_V_CODE_to.TabIndex = 78;
            this.txt_V_CODE_to.Tag = "Invontory_ID";
            this.txt_V_CODE_to.TextChanged += new System.EventHandler(this.txt_Account_ID_TextChanged);
            this.txt_V_CODE_to.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_V_CODE_to_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_V_curr);
            this.panel1.Location = new System.Drawing.Point(4, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 246);
            this.panel1.TabIndex = 117;
            // 
            // dgv_V_curr
            // 
            this.dgv_V_curr.AllowUserToAddRows = false;
            this.dgv_V_curr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_V_curr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.V_CODE,
            this.V_A_NAME,
            this.Product_ID,
            this.A_N,
            this.COST,
            this.currency_Key,
            this.I_PACKING});
            this.dgv_V_curr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_V_curr.Location = new System.Drawing.Point(0, 0);
            this.dgv_V_curr.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_V_curr.Name = "dgv_V_curr";
            this.dgv_V_curr.Size = new System.Drawing.Size(919, 246);
            this.dgv_V_curr.TabIndex = 93;
            // 
            // V_CODE
            // 
            this.V_CODE.HeaderText = "رقم المورد";
            this.V_CODE.Name = "V_CODE";
            // 
            // V_A_NAME
            // 
            this.V_A_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.V_A_NAME.HeaderText = "اسم المورد";
            this.V_A_NAME.Name = "V_A_NAME";
            this.V_A_NAME.Width = 120;
            // 
            // Product_ID
            // 
            this.Product_ID.HeaderText = "رقم النصف";
            this.Product_ID.Name = "Product_ID";
            // 
            // A_N
            // 
            this.A_N.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.A_N.HeaderText = "اسم الصنف";
            this.A_N.Name = "A_N";
            this.A_N.Width = 160;
            // 
            // COST
            // 
            this.COST.HeaderText = "السعر";
            this.COST.Name = "COST";
            // 
            // currency_Key
            // 
            this.currency_Key.HeaderText = "العملة";
            this.currency_Key.Name = "currency_Key";
            // 
            // I_PACKING
            // 
            this.I_PACKING.HeaderText = "العبوة";
            this.I_PACKING.Name = "I_PACKING";
            // 
            // cbx_minor
            // 
            this.cbx_minor.FormattingEnabled = true;
            this.cbx_minor.Items.AddRange(new object[] {
            "حسب المورد",
            "حسب الصنف"});
            this.cbx_minor.Location = new System.Drawing.Point(482, 22);
            this.cbx_minor.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_minor.Name = "cbx_minor";
            this.cbx_minor.Size = new System.Drawing.Size(291, 24);
            this.cbx_minor.TabIndex = 93;
            this.cbx_minor.SelectedIndexChanged += new System.EventHandler(this.cbx_minor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 92;
            this.label8.Text = "طريقة ادخال البيانات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "الى";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(798, 54);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 17);
            this.label19.TabIndex = 82;
            this.label19.Text = "رقم المورد";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(798, 90);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 17);
            this.label21.TabIndex = 80;
            this.label21.Text = "رقم الصنف";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(300, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 17);
            this.label22.TabIndex = 79;
            this.label22.Text = "الى";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(911, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "صلاحيات";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_invantory_user);
            this.groupBox4.Location = new System.Drawing.Point(8, 102);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(924, 317);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "لمستخدمين و صلاحيات";
            // 
            // dgv_invantory_user
            // 
            this.dgv_invantory_user.AllowUserToAddRows = false;
            this.dgv_invantory_user.AllowUserToDeleteRows = false;
            this.dgv_invantory_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_invantory_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invantory_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_invantory_user.Location = new System.Drawing.Point(4, 19);
            this.dgv_invantory_user.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_invantory_user.Name = "dgv_invantory_user";
            this.dgv_invantory_user.Size = new System.Drawing.Size(916, 294);
            this.dgv_invantory_user.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_save_change);
            this.groupBox3.Controls.Add(this.btn_show_user_branch);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.textBox20);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txt_invantory_id2);
            this.groupBox3.Location = new System.Drawing.Point(8, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(916, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المخزن";
            // 
            // btn_save_change
            // 
            this.btn_save_change.Location = new System.Drawing.Point(236, 48);
            this.btn_save_change.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_save_change.Name = "btn_save_change";
            this.btn_save_change.Size = new System.Drawing.Size(132, 32);
            this.btn_save_change.TabIndex = 32;
            this.btn_save_change.Text = "حفظ التغيرات";
            this.btn_save_change.UseVisualStyleBackColor = true;
            // 
            // btn_show_user_branch
            // 
            this.btn_show_user_branch.Location = new System.Drawing.Point(387, 48);
            this.btn_show_user_branch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_show_user_branch.Name = "btn_show_user_branch";
            this.btn_show_user_branch.Size = new System.Drawing.Size(132, 32);
            this.btn_show_user_branch.TabIndex = 31;
            this.btn_show_user_branch.Text = "عرض المستخدمين";
            this.btn_show_user_branch.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(833, 23);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 17);
            this.label26.TabIndex = 30;
            this.label26.Text = "رقم المخزن";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(564, 49);
            this.textBox20.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(264, 22);
            this.textBox20.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(833, 52);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 17);
            this.label25.TabIndex = 28;
            this.label25.Text = "اسم الفرع";
            // 
            // txt_invantory_id2
            // 
            this.txt_invantory_id2.Location = new System.Drawing.Point(752, 20);
            this.txt_invantory_id2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_invantory_id2.Name = "txt_invantory_id2";
            this.txt_invantory_id2.Size = new System.Drawing.Size(79, 22);
            this.txt_invantory_id2.TabIndex = 27;
            // 
            // frm_VI_DETAILS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_VI_DETAILS";
            this.Text = "بيانات التوريد";
            this.Load += new System.EventHandler(this.frm_VI_DETAILS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_curr)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invantory_user)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox txt_Product_ID_to;
        private System.Windows.Forms.TextBox txt_V_CODE;
        private System.Windows.Forms.TextBox txt_Product_ID;
        private System.Windows.Forms.TextBox txt_V_CODE_to;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_V_curr;
        private System.Windows.Forms.ComboBox cbx_minor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_invantory_user;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_save_change;
        private System.Windows.Forms.Button btn_show_user_branch;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_invantory_id2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbx_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn V_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn V_A_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_PACKING;
    }
}