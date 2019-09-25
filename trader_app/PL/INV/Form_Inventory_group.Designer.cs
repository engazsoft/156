namespace trader_app.PL.INV
{
    partial class Form_Inventory_group
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
            this.cbx_inventory_group = new System.Windows.Forms.ComboBox();
            this.groupBox_Data.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.txt_E_N);
            this.groupBox_Data.Controls.Add(this.label9);
            this.groupBox_Data.Controls.Add(this.label8);
            this.groupBox_Data.Controls.Add(this.label1);
            this.groupBox_Data.Controls.Add(this.txt_A_N);
            this.groupBox_Data.Controls.Add(this.cbx_inventory_group);
            this.groupBox_Data.Size = new System.Drawing.Size(701, 252);
            this.groupBox_Data.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(95, 252);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 252);
            this.groupBox1.Size = new System.Drawing.Size(796, 113);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(650, 22);
            // 
            // txt_edit_user
            // 
            this.txt_edit_user.BackColor = System.Drawing.Color.White;
            this.txt_edit_user.Location = new System.Drawing.Point(436, 62);
            this.txt_edit_user.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(650, 65);
            // 
            // txt_edit_date
            // 
            this.txt_edit_date.BackColor = System.Drawing.Color.White;
            this.txt_edit_date.Location = new System.Drawing.Point(25, 62);
            this.txt_edit_date.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(239, 65);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(239, 26);
            // 
            // txt_in_date
            // 
            this.txt_in_date.BackColor = System.Drawing.Color.White;
            this.txt_in_date.Location = new System.Drawing.Point(437, 23);
            this.txt_in_date.ReadOnly = true;
            // 
            // txt_py_user
            // 
            this.txt_by_user.BackColor = System.Drawing.Color.White;
            this.txt_by_user.Location = new System.Drawing.Point(25, 22);
            this.txt_by_user.ReadOnly = true;
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
            // txt_E_N
            // 
            this.txt_E_N.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_E_N.Location = new System.Drawing.Point(127, 148);
            this.txt_E_N.Name = "txt_E_N";
            this.txt_E_N.Size = new System.Drawing.Size(361, 20);
            this.txt_E_N.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "اسم المجموعة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "لاسم بالاجنبي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "رقم المجموعة";
            // 
            // txt_A_N
            // 
            this.txt_A_N.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_A_N.Location = new System.Drawing.Point(127, 114);
            this.txt_A_N.Name = "txt_A_N";
            this.txt_A_N.Size = new System.Drawing.Size(361, 20);
            this.txt_A_N.TabIndex = 15;
            // 
            // cbx_inventory_group
            // 
            this.cbx_inventory_group.FormattingEnabled = true;
            this.cbx_inventory_group.Location = new System.Drawing.Point(289, 83);
            this.cbx_inventory_group.Name = "cbx_inventory_group";
            this.cbx_inventory_group.Size = new System.Drawing.Size(199, 21);
            this.cbx_inventory_group.TabIndex = 14;
            this.cbx_inventory_group.DropDown += new System.EventHandler(this.cbx_inventory_group_DropDown_1);
            // 
            // Form_Inventory_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 365);
            this.Name = "Form_Inventory_group";
            this.Text = "مجموعات المخازن";
            this.Load += new System.EventHandler(this.Form_Inventory_group_Load);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox txt_E_N;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txt_A_N;
        private System.Windows.Forms.ComboBox cbx_inventory_group;
    }
}