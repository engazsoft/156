namespace trader_app.PL.SUP
{
    partial class FRM_VENDOR_GROUP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_E_N = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_A_N = new System.Windows.Forms.TextBox();
            this.txt_V_ACCOUNT_ID = new System.Windows.Forms.TextBox();
            this.txt_V_GROUP_CODE = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 337);
            this.groupBox1.Size = new System.Drawing.Size(1092, 74);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(125, 337);
            // 
            // btn_repeal
            // 
            this.btn_repeal.Location = new System.Drawing.Point(4, 219);
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
            // btn_add
            // 
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.panel1);
            this.groupBox_Data.Size = new System.Drawing.Size(967, 337);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_E_N);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_A_N);
            this.panel1.Controls.Add(this.txt_V_ACCOUNT_ID);
            this.panel1.Controls.Add(this.txt_V_GROUP_CODE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 314);
            this.panel1.TabIndex = 1;
            // 
            // txt_E_N
            // 
            this.txt_E_N.Location = new System.Drawing.Point(333, 148);
            this.txt_E_N.Margin = new System.Windows.Forms.Padding(4);
            this.txt_E_N.Name = "txt_E_N";
            this.txt_E_N.Size = new System.Drawing.Size(480, 22);
            this.txt_E_N.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(835, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "اسم المجموعة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(835, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "الاسم بالاجنبي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "رقم حساب المجموعة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "رقم المجموعة";
            // 
            // txt_A_N
            // 
            this.txt_A_N.Location = new System.Drawing.Point(333, 111);
            this.txt_A_N.Margin = new System.Windows.Forms.Padding(4);
            this.txt_A_N.Name = "txt_A_N";
            this.txt_A_N.Size = new System.Drawing.Size(480, 22);
            this.txt_A_N.TabIndex = 36;
            // 
            // txt_V_ACCOUNT_ID
            // 
            this.txt_V_ACCOUNT_ID.Location = new System.Drawing.Point(574, 184);
            this.txt_V_ACCOUNT_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_V_ACCOUNT_ID.Name = "txt_V_ACCOUNT_ID";
            this.txt_V_ACCOUNT_ID.Size = new System.Drawing.Size(239, 22);
            this.txt_V_ACCOUNT_ID.TabIndex = 36;
            this.txt_V_ACCOUNT_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // txt_V_GROUP_CODE
            // 
            this.txt_V_GROUP_CODE.Location = new System.Drawing.Point(574, 76);
            this.txt_V_GROUP_CODE.Margin = new System.Windows.Forms.Padding(4);
            this.txt_V_GROUP_CODE.Name = "txt_V_GROUP_CODE";
            this.txt_V_GROUP_CODE.Size = new System.Drawing.Size(239, 22);
            this.txt_V_GROUP_CODE.TabIndex = 36;
            this.txt_V_GROUP_CODE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_V_GROUP_CODE_KeyDown);
            // 
            // FRM_VENDOR_GROUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 411);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FRM_VENDOR_GROUP";
            this.Text = "مجموعة الموردين ";
            this.Load += new System.EventHandler(this.FRM_VENDOR_GROUP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_E_N;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_A_N;
        private System.Windows.Forms.TextBox txt_V_GROUP_CODE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_V_ACCOUNT_ID;
    }
}