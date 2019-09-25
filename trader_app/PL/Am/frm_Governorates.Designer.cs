namespace trader_app.PL.Am
{
    partial class frm_Governorates
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
            this.txt_E_N = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_A_N = new System.Windows.Forms.TextBox();
            this.cbx_Country = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 275);
            this.groupBox1.Size = new System.Drawing.Size(804, 60);
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
            this.groupBox2.Size = new System.Drawing.Size(94, 275);
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
            this.groupBox_Data.Controls.Add(this.txt_id);
            this.groupBox_Data.Controls.Add(this.label3);
            this.groupBox_Data.Controls.Add(this.cbx_Country);
            this.groupBox_Data.Controls.Add(this.txt_E_N);
            this.groupBox_Data.Controls.Add(this.label9);
            this.groupBox_Data.Controls.Add(this.label8);
            this.groupBox_Data.Controls.Add(this.label1);
            this.groupBox_Data.Controls.Add(this.txt_A_N);
            this.groupBox_Data.Size = new System.Drawing.Size(710, 275);
            this.groupBox_Data.Enter += new System.EventHandler(this.groupBox_Data_Enter);
            // 
            // txt_E_N
            // 
            this.txt_E_N.Location = new System.Drawing.Point(122, 135);
            this.txt_E_N.Name = "txt_E_N";
            this.txt_E_N.Size = new System.Drawing.Size(361, 20);
            this.txt_E_N.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "اسم الحافظة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "لاسم بالاجنبي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 26;
            this.label1.Tag = "Gov_id";
            this.label1.Text = "رقم المحافظة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_A_N
            // 
            this.txt_A_N.Location = new System.Drawing.Point(122, 105);
            this.txt_A_N.Name = "txt_A_N";
            this.txt_A_N.Size = new System.Drawing.Size(361, 20);
            this.txt_A_N.TabIndex = 25;
            // 
            // cbx_Country
            // 
            this.cbx_Country.FormattingEnabled = true;
            this.cbx_Country.Location = new System.Drawing.Point(284, 78);
            this.cbx_Country.Name = "cbx_Country";
            this.cbx_Country.Size = new System.Drawing.Size(199, 21);
            this.cbx_Country.TabIndex = 30;
            this.cbx_Country.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "الدولة";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(284, 47);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(199, 20);
            this.txt_id.TabIndex = 32;
            this.txt_id.Tag = "Gov_ID";
            // 
            // frm_Governorates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 335);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "frm_Governorates";
            this.Tag = "am_governorates";
            this.Text = "frm_Governorates";
            this.Load += new System.EventHandler(this.frm_Governorates_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_Governorates_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Country;
        private System.Windows.Forms.TextBox txt_E_N;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_A_N;
        private System.Windows.Forms.TextBox txt_id;
    }
}