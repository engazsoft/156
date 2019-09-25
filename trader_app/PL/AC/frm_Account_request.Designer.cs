namespace trader_app.PL.AC
{
    partial class frm_Account_request
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
            this.cbx_parent = new System.Windows.Forms.ComboBox();
            this.cbx_Account_Calss = new System.Windows.Forms.ComboBox();
            this.cbx_Account_group = new System.Windows.Forms.ComboBox();
            this.cbx_Account_type = new System.Windows.Forms.ComboBox();
            this.txt_E_N = new System.Windows.Forms.TextBox();
            this.txt_A_N = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.T_C = new System.Windows.Forms.TabControl();
            this.cbx_Acount_group = new System.Windows.Forms.TabPage();
            this.chbx_INACTIVE_add = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_pareant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.T_C.SuspendLayout();
            this.cbx_Acount_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 442);
            this.groupBox1.Size = new System.Drawing.Size(1081, 74);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(125, 442);
            // 
            // btn_repeal
            // 
            this.btn_repeal.Location = new System.Drawing.Point(4, 219);
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
            this.groupBox_Data.Controls.Add(this.T_C);
            this.groupBox_Data.Size = new System.Drawing.Size(956, 442);
            // 
            // cbx_parent
            // 
            this.cbx_parent.FormattingEnabled = true;
            this.cbx_parent.Location = new System.Drawing.Point(517, 22);
            this.cbx_parent.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_parent.Name = "cbx_parent";
            this.cbx_parent.Size = new System.Drawing.Size(284, 24);
            this.cbx_parent.TabIndex = 42;
            // 
            // cbx_Account_Calss
            // 
            this.cbx_Account_Calss.FormattingEnabled = true;
            this.cbx_Account_Calss.Location = new System.Drawing.Point(428, 147);
            this.cbx_Account_Calss.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Account_Calss.Name = "cbx_Account_Calss";
            this.cbx_Account_Calss.Size = new System.Drawing.Size(373, 24);
            this.cbx_Account_Calss.TabIndex = 31;
            // 
            // cbx_Account_group
            // 
            this.cbx_Account_group.FormattingEnabled = true;
            this.cbx_Account_group.Location = new System.Drawing.Point(428, 209);
            this.cbx_Account_group.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Account_group.Name = "cbx_Account_group";
            this.cbx_Account_group.Size = new System.Drawing.Size(373, 24);
            this.cbx_Account_group.TabIndex = 22;
            // 
            // cbx_Account_type
            // 
            this.cbx_Account_type.FormattingEnabled = true;
            this.cbx_Account_type.Location = new System.Drawing.Point(428, 180);
            this.cbx_Account_type.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Account_type.Name = "cbx_Account_type";
            this.cbx_Account_type.Size = new System.Drawing.Size(373, 24);
            this.cbx_Account_type.TabIndex = 20;
            // 
            // txt_E_N
            // 
            this.txt_E_N.Location = new System.Drawing.Point(349, 114);
            this.txt_E_N.Margin = new System.Windows.Forms.Padding(4);
            this.txt_E_N.Name = "txt_E_N";
            this.txt_E_N.Size = new System.Drawing.Size(452, 22);
            this.txt_E_N.TabIndex = 18;
            // 
            // txt_A_N
            // 
            this.txt_A_N.Location = new System.Drawing.Point(349, 83);
            this.txt_A_N.Margin = new System.Windows.Forms.Padding(4);
            this.txt_A_N.Name = "txt_A_N";
            this.txt_A_N.Size = new System.Drawing.Size(452, 22);
            this.txt_A_N.TabIndex = 16;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(630, 54);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(171, 22);
            this.txt_id.TabIndex = 11;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            // 
            // T_C
            // 
            this.T_C.Controls.Add(this.cbx_Acount_group);
            this.T_C.Controls.Add(this.tabPage2);
            this.T_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T_C.Location = new System.Drawing.Point(4, 19);
            this.T_C.Margin = new System.Windows.Forms.Padding(4);
            this.T_C.Name = "T_C";
            this.T_C.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.T_C.RightToLeftLayout = true;
            this.T_C.SelectedIndex = 0;
            this.T_C.Size = new System.Drawing.Size(948, 419);
            this.T_C.TabIndex = 1;
            // 
            // cbx_Acount_group
            // 
            this.cbx_Acount_group.Controls.Add(this.chbx_INACTIVE_add);
            this.cbx_Acount_group.Controls.Add(this.cbx_parent);
            this.cbx_Acount_group.Controls.Add(this.label15);
            this.cbx_Acount_group.Controls.Add(this.txt_Note);
            this.cbx_Acount_group.Controls.Add(this.button2);
            this.cbx_Acount_group.Controls.Add(this.label14);
            this.cbx_Acount_group.Controls.Add(this.cbx_Account_Calss);
            this.cbx_Acount_group.Controls.Add(this.label10);
            this.cbx_Acount_group.Controls.Add(this.cbx_Account_group);
            this.cbx_Acount_group.Controls.Add(this.label9);
            this.cbx_Acount_group.Controls.Add(this.cbx_Account_type);
            this.cbx_Acount_group.Controls.Add(this.label2);
            this.cbx_Acount_group.Controls.Add(this.txt_E_N);
            this.cbx_Acount_group.Controls.Add(this.label8);
            this.cbx_Acount_group.Controls.Add(this.txt_A_N);
            this.cbx_Acount_group.Controls.Add(this.lb_pareant);
            this.cbx_Acount_group.Controls.Add(this.label1);
            this.cbx_Acount_group.Controls.Add(this.txt_id);
            this.cbx_Acount_group.Location = new System.Drawing.Point(4, 25);
            this.cbx_Acount_group.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Acount_group.Name = "cbx_Acount_group";
            this.cbx_Acount_group.Padding = new System.Windows.Forms.Padding(4);
            this.cbx_Acount_group.Size = new System.Drawing.Size(940, 390);
            this.cbx_Acount_group.TabIndex = 0;
            this.cbx_Acount_group.Text = "الحسابات";
            this.cbx_Acount_group.UseVisualStyleBackColor = true;
            // 
            // chbx_INACTIVE_add
            // 
            this.chbx_INACTIVE_add.AutoSize = true;
            this.chbx_INACTIVE_add.Enabled = false;
            this.chbx_INACTIVE_add.Location = new System.Drawing.Point(744, 269);
            this.chbx_INACTIVE_add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chbx_INACTIVE_add.Name = "chbx_INACTIVE_add";
            this.chbx_INACTIVE_add.Size = new System.Drawing.Size(57, 21);
            this.chbx_INACTIVE_add.TabIndex = 56;
            this.chbx_INACTIVE_add.Text = "اضافة";
            this.chbx_INACTIVE_add.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(821, 246);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "الملاحظة";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(428, 241);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(376, 22);
            this.txt_Note.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 26);
            this.button2.TabIndex = 36;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(820, 153);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "تصنيف الحساب";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(820, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "مجموعة الحساب";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(820, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "نوع الحساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "الاسم الاجنبي";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(820, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "اسم الحساب";
            // 
            // lb_pareant
            // 
            this.lb_pareant.AutoSize = true;
            this.lb_pareant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lb_pareant.Location = new System.Drawing.Point(821, 24);
            this.lb_pareant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pareant.Name = "lb_pareant";
            this.lb_pareant.Size = new System.Drawing.Size(83, 17);
            this.lb_pareant.TabIndex = 14;
            this.lb_pareant.Text = " الحساب الرئسي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "رقم الاحساب";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(911, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frm_Account_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 516);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_Account_request";
            this.Text = "frm_Account_request";
            this.Load += new System.EventHandler(this.frm_Account_request_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.T_C.ResumeLayout(false);
            this.cbx_Acount_group.ResumeLayout(false);
            this.cbx_Acount_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl T_C;
        private System.Windows.Forms.TabPage cbx_Acount_group;
        private System.Windows.Forms.ComboBox cbx_parent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbx_Account_Calss;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_Account_group;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_Account_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_E_N;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_A_N;
        private System.Windows.Forms.Label lb_pareant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chbx_INACTIVE_add;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Note;
        public System.Windows.Forms.TextBox txt_id;
    }
}