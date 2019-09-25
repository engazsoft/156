namespace trader_app.PL
{
    partial class order_frm
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 346);
            this.groupBox1.Size = new System.Drawing.Size(996, 60);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_edit_user
            // 
            this.txt_edit_user.BackColor = System.Drawing.Color.White;
            this.txt_edit_user.ReadOnly = true;
            this.txt_edit_user.TextChanged += new System.EventHandler(this.txt_edit_user_TextChanged);
            // 
            // label6
            // 
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_edit_date
            // 
            this.txt_edit_date.BackColor = System.Drawing.Color.White;
            this.txt_edit_date.ReadOnly = true;
            this.txt_edit_date.TextChanged += new System.EventHandler(this.txt_edit_date_TextChanged);
            // 
            // label5
            // 
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_in_date
            // 
            this.txt_in_date.BackColor = System.Drawing.Color.White;
            this.txt_in_date.ReadOnly = true;
            this.txt_in_date.TextChanged += new System.EventHandler(this.txt_in_date_TextChanged);
            // 
            // txt_by_user
            // 
            this.txt_by_user.BackColor = System.Drawing.Color.White;
            this.txt_by_user.ReadOnly = true;
            this.txt_by_user.TextChanged += new System.EventHandler(this.txt_by_user_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(94, 346);
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_repeal
            // 
            this.btn_repeal.Click += new System.EventHandler(this.btn_repeal_Click);
            // 
            // btn_dele
            // 
            this.btn_dele.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_serch
            // 
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_seve
            // 
            this.btn_seve.Click += new System.EventHandler(this.btn_seve_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.groupBox_Data.Controls.Add(this.label9);
            this.groupBox_Data.Controls.Add(this.txt_id);
            this.groupBox_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Data.Size = new System.Drawing.Size(902, 167);
            this.groupBox_Data.Enter += new System.EventHandler(this.groupBox_Data_Enter);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(685, 22);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(160, 20);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(851, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "رقم الامر ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // order_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 406);
            this.Name = "order_frm";
            this.Text = "امر تحويل مخزني";
            this.Load += new System.EventHandler(this.order_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_id;
    }
}