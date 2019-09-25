namespace trader_app.PL.AC
{
    partial class frm_Account_Group
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_A_N = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Data.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.txt_E_N);
            this.groupBox_Data.Controls.Add(this.label3);
            this.groupBox_Data.Controls.Add(this.txt_A_N);
            this.groupBox_Data.Controls.Add(this.label2);
            this.groupBox_Data.Controls.Add(this.txt_id);
            this.groupBox_Data.Controls.Add(this.label1);
            this.groupBox_Data.Size = new System.Drawing.Size(945, 341);
            this.groupBox_Data.Enter += new System.EventHandler(this.groupBox_Data_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(126, 341);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 341);
            this.groupBox1.Size = new System.Drawing.Size(1071, 156);
            // 
            // txt_edit_user
            // 
            this.txt_edit_user.BackColor = System.Drawing.Color.White;
            this.txt_edit_user.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_edit_user.ReadOnly = true;
            // 
            // txt_edit_date
            // 
            this.txt_edit_date.BackColor = System.Drawing.Color.White;
            this.txt_edit_date.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_edit_date.ReadOnly = true;
            // 
            // txt_in_date
            // 
            this.txt_in_date.BackColor = System.Drawing.Color.White;
            this.txt_in_date.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_in_date.ReadOnly = true;
            // 
            // txt_by_user
            // 
            this.txt_by_user.BackColor = System.Drawing.Color.White;
            this.txt_by_user.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_by_user.ReadOnly = true;
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
            // txt_E_N
            // 
            this.txt_E_N.Location = new System.Drawing.Point(457, 113);
            this.txt_E_N.Name = "txt_E_N";
            this.txt_E_N.Size = new System.Drawing.Size(262, 26);
            this.txt_E_N.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "الاسم بالاجنبي";
            // 
            // txt_A_N
            // 
            this.txt_A_N.Location = new System.Drawing.Point(457, 79);
            this.txt_A_N.Name = "txt_A_N";
            this.txt_A_N.Size = new System.Drawing.Size(262, 26);
            this.txt_A_N.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "الاسم ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(619, 47);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 26);
            this.txt_id.TabIndex = 8;
            this.txt_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "الرقم";
            // 
            // frm_Account_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 497);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_Account_Group";
            this.Text = "frm_Account_Group";
            this.Load += new System.EventHandler(this.frm_Account_Group_Load);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_E_N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_A_N;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
    }
}