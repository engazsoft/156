namespace trader_app.PL.Am
{
    partial class Frm_Campny
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_E = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_A_N = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_E_N = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_grop_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_country = new System.Windows.Forms.ComboBox();
            this.pic_log = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_log)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 303);
            this.groupBox1.Size = new System.Drawing.Size(803, 113);
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
            this.groupBox2.Size = new System.Drawing.Size(95, 303);
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
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_add
            // 
            this.btn_add.Size = new System.Drawing.Size(89, 23);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.pic_log);
            this.groupBox_Data.Controls.Add(this.cbx_country);
            this.groupBox_Data.Controls.Add(this.label12);
            this.groupBox_Data.Controls.Add(this.txt_grop_ID);
            this.groupBox_Data.Controls.Add(this.label11);
            this.groupBox_Data.Controls.Add(this.txt_E_N);
            this.groupBox_Data.Controls.Add(this.label10);
            this.groupBox_Data.Controls.Add(this.txt_A_N);
            this.groupBox_Data.Controls.Add(this.label9);
            this.groupBox_Data.Controls.Add(this.txt_A);
            this.groupBox_Data.Controls.Add(this.label8);
            this.groupBox_Data.Controls.Add(this.txt_E);
            this.groupBox_Data.Controls.Add(this.label3);
            this.groupBox_Data.Controls.Add(this.txt_note);
            this.groupBox_Data.Controls.Add(this.label2);
            this.groupBox_Data.Controls.Add(this.txt_id);
            this.groupBox_Data.Controls.Add(this.label1);
            this.groupBox_Data.Location = new System.Drawing.Point(95, 0);
            this.groupBox_Data.Size = new System.Drawing.Size(708, 303);
            // 
            // btn_ifect_account
            // 
            this.btn_ifect_account.Size = new System.Drawing.Size(89, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الشركة";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(498, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(113, 20);
            this.txt_id.TabIndex = 1;
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(305, 170);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(307, 20);
            this.txt_note.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ملاحظات";
            // 
            // txt_E
            // 
            this.txt_E.Location = new System.Drawing.Point(446, 144);
            this.txt_E.Name = "txt_E";
            this.txt_E.Size = new System.Drawing.Size(166, 20);
            this.txt_E.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "المختصر الاجنبي";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(446, 116);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(166, 20);
            this.txt_A.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "الاسم الاجنبي";
            // 
            // txt_A_N
            // 
            this.txt_A_N.Location = new System.Drawing.Point(305, 65);
            this.txt_A_N.Name = "txt_A_N";
            this.txt_A_N.Size = new System.Drawing.Size(307, 20);
            this.txt_A_N.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(630, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "اسم الشركة";
            // 
            // txt_E_N
            // 
            this.txt_E_N.Location = new System.Drawing.Point(305, 91);
            this.txt_E_N.Name = "txt_E_N";
            this.txt_E_N.Size = new System.Drawing.Size(307, 20);
            this.txt_E_N.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(633, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "الاسم المختصر";
            // 
            // txt_grop_ID
            // 
            this.txt_grop_ID.Location = new System.Drawing.Point(446, 206);
            this.txt_grop_ID.Name = "txt_grop_ID";
            this.txt_grop_ID.Size = new System.Drawing.Size(166, 20);
            this.txt_grop_ID.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(633, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "رقم المجموعة";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(633, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "الدولة";
            // 
            // cbx_country
            // 
            this.cbx_country.DropDownHeight = 60;
            this.cbx_country.FormattingEnabled = true;
            this.cbx_country.IntegralHeight = false;
            this.cbx_country.Location = new System.Drawing.Point(446, 242);
            this.cbx_country.Name = "cbx_country";
            this.cbx_country.Size = new System.Drawing.Size(172, 21);
            this.cbx_country.TabIndex = 89;
            // 
            // pic_log
            // 
            this.pic_log.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pic_log.Image = global::trader_app.Properties.Resources.انجاز;
            this.pic_log.Location = new System.Drawing.Point(57, 17);
            this.pic_log.Name = "pic_log";
            this.pic_log.Size = new System.Drawing.Size(116, 145);
            this.pic_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_log.TabIndex = 90;
            this.pic_log.TabStop = false;
            this.pic_log.Click += new System.EventHandler(this.pic_log_Click);
            // 
            // Frm_Campny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 416);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Campny";
            this.Text = "++++++++++++++++++++++++++++++++";
            this.Load += new System.EventHandler(this.Frm_Campny_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_grop_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_E_N;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_A_N;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_E;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_log;
        private System.Windows.Forms.ComboBox cbx_country;
    }
}