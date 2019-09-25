namespace trader_app.PL.SUP
{
    partial class frm_PREQ_TYPES
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_A_N = new System.Windows.Forms.TextBox();
            this.txt_PR_TYPE = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_A_N);
            this.panel1.Controls.Add(this.txt_PR_TYPE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 314);
            this.panel1.TabIndex = 2;
            // 
            // txt_E_N
            // 
            this.txt_E_N.Location = new System.Drawing.Point(357, 146);
            this.txt_E_N.Margin = new System.Windows.Forms.Padding(4);
            this.txt_E_N.Name = "txt_E_N";
            this.txt_E_N.Size = new System.Drawing.Size(480, 22);
            this.txt_E_N.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(877, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "اسم النوع";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(859, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "لاسم بالاجنبي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(877, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "رقم النوع";
            // 
            // txt_A_N
            // 
            this.txt_A_N.Location = new System.Drawing.Point(357, 108);
            this.txt_A_N.Margin = new System.Windows.Forms.Padding(4);
            this.txt_A_N.Name = "txt_A_N";
            this.txt_A_N.Size = new System.Drawing.Size(480, 22);
            this.txt_A_N.TabIndex = 36;
            // 
            // txt_PR_TYPE
            // 
            this.txt_PR_TYPE.Location = new System.Drawing.Point(598, 71);
            this.txt_PR_TYPE.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PR_TYPE.Name = "txt_PR_TYPE";
            this.txt_PR_TYPE.Size = new System.Drawing.Size(239, 22);
            this.txt_PR_TYPE.TabIndex = 36;
            this.txt_PR_TYPE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PR_TYPE_KeyDown);
            // 
            // frm_PREQ_TYPES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 411);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_PREQ_TYPES";
            this.Text = "انواع طلبات الشراء";
            this.Load += new System.EventHandler(this.frm_PREQ_TYPES_Load);
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
        private System.Windows.Forms.TextBox txt_PR_TYPE;
    }
}