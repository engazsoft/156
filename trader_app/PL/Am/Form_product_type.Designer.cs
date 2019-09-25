namespace trader_app.PL.Am
{
    partial class Form_product_type
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
            this.cbx_product_type_num = new System.Windows.Forms.ComboBox();
            this.txt_A_N = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_E_N = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 460);
            this.groupBox1.Size = new System.Drawing.Size(895, 113);
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
            this.groupBox2.Size = new System.Drawing.Size(95, 460);
            // 
            // btn_repeal
            // 
            this.btn_repeal.Size = new System.Drawing.Size(89, 23);
            // 
            // btn_dele
            // 
            this.btn_dele.Size = new System.Drawing.Size(89, 26);
            // 
            // btn_serch
            // 
            this.btn_serch.Size = new System.Drawing.Size(89, 23);
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Size = new System.Drawing.Size(89, 23);
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_seve
            // 
            this.btn_seve.Size = new System.Drawing.Size(89, 23);
            this.btn_seve.Click += new System.EventHandler(this.btn_seve_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Size = new System.Drawing.Size(89, 23);
            // 
            // btn_view
            // 
            this.btn_view.Size = new System.Drawing.Size(89, 23);
            this.btn_view.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add
            // 
            this.btn_add.Size = new System.Drawing.Size(89, 23);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.txt_E_N);
            this.groupBox_Data.Controls.Add(this.label9);
            this.groupBox_Data.Controls.Add(this.label8);
            this.groupBox_Data.Controls.Add(this.label1);
            this.groupBox_Data.Controls.Add(this.txt_A_N);
            this.groupBox_Data.Controls.Add(this.cbx_product_type_num);
            this.groupBox_Data.Location = new System.Drawing.Point(95, 0);
            this.groupBox_Data.Size = new System.Drawing.Size(800, 460);
            // 
            // btn_ifect_account
            // 
            this.btn_ifect_account.Size = new System.Drawing.Size(89, 23);
            // 
            // cbx_product_type_num
            // 
            this.cbx_product_type_num.FormattingEnabled = true;
            this.cbx_product_type_num.Location = new System.Drawing.Point(420, 106);
            this.cbx_product_type_num.Name = "cbx_product_type_num";
            this.cbx_product_type_num.Size = new System.Drawing.Size(199, 21);
            this.cbx_product_type_num.TabIndex = 0;
            this.cbx_product_type_num.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.cbx_product_type_num.SelectedIndexChanged += new System.EventHandler(this.cbx_product_type_num_SelectedIndexChanged);
            this.cbx_product_type_num.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbx_product_type_num_KeyUp);
            // 
            // txt_A_N
            // 
            this.txt_A_N.Location = new System.Drawing.Point(258, 137);
            this.txt_A_N.Name = "txt_A_N";
            this.txt_A_N.Size = new System.Drawing.Size(361, 20);
            this.txt_A_N.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم النوع";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(653, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "لاسم بالاجنبي";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "اسم النوع";
            // 
            // txt_E_N
            // 
            this.txt_E_N.Location = new System.Drawing.Point(258, 171);
            this.txt_E_N.Name = "txt_E_N";
            this.txt_E_N.Size = new System.Drawing.Size(361, 20);
            this.txt_E_N.TabIndex = 7;
            // 
            // Form_product_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 573);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form_product_type";
            this.Text = "Form_product_type";
            this.Load += new System.EventHandler(this.Form_product_type_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_E_N;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_A_N;
        private System.Windows.Forms.ComboBox cbx_product_type_num;
    }
}